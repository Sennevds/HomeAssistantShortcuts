#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HomeAssistantShortcuts.Helper;
using Newtonsoft.Json;

namespace HomeAssistantShortcuts
{
    sealed class PingResponse
    {
        public string? message { get; set; }
    }

    public sealed class ServerConnection : IDisposable
    {
        private HttpClient? client = null;

        public string BaseUrl
        {
            set
            {
                if (value.Last() != '/')
                {
                    value.Append('/');
                }

                client = new HttpClient
                {
                    BaseAddress = new Uri(value),
                    Timeout = TimeSpan.FromSeconds(10)
                };
            }
        }

        public string? Token { set; private get; }

        public void Dispose()
        {
            client?.Dispose();
            client = null;
            GC.SuppressFinalize(this);
        }

        private async Task<T> Api<T>(HttpMethod method, string path, string body = null)
        {
            if (client is null)
            {
                throw new Exception($"{nameof(ServerConnection)}.{nameof(ServerConnection.Api)} called before {nameof(BaseUrl)} has been set");
            }
            if (Token is null)
            {
                throw new Exception($"{nameof(ServerConnection)}.{nameof(ServerConnection.Api)} called before {nameof(Token)} has been set");
            }

            using var message = new HttpRequestMessage(method, path);
            message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            message.Headers.Add("Accept", "application/json");

            //using var bodyStream = new MemoryStream();
            var serializer = new JsonSerializer();
            if (!(body is null))
            {

                //= new StreamContent(bodyStream);
                message.Content = new StringContent(body, Encoding.UTF8, "application/json");

                //message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            using var response = await client.SendAsync(message);
            response.EnsureSuccessStatusCode();

            using var stream = await response.Content.ReadAsStreamAsync();
            var jsonTextReader = new JsonTextReader(new StreamReader(stream));

            return serializer.Deserialize<T>(jsonTextReader);
            //return await JsonSerializer.DeserializeAsync<T>(stream);
        }

        public async Task<string?> Ping()
        {
            var response = await Api<PingResponse>(HttpMethod.Get, "");
            return response.message;
        }

        public async Task<List<Service>> ListServices()
        {
            var response = await Api<List<ServiceResponseItem>>(HttpMethod.Get, "services");
            return (
                from item in response
                from service in item.Services
                orderby item.Domain, service.Key
                select new Service(service.Value.Description, item.Domain,service.Key, service.Value.Fields)
            ).ToList();
        }

        public async Task<List<object>> CallService(string path, string payload = "")
        {
            return await Api<List<object>>(HttpMethod.Post, $"services/{path}", payload);
        }

        public async Task<List<T>> Get<T>(string path, string payload = null) where T : class
        {
            return await Api<List<T>>(HttpMethod.Get, $"{path}", payload);
        }
    }
}
