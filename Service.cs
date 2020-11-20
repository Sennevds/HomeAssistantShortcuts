using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAssistantShortcuts.Helper;
using Newtonsoft.Json;

namespace HomeAssistantShortcuts
{

    //sealed class ServiceResponseItem
    //{
    //    public string? domain { get; set; }
    //    public Dictionary<string, ServiceResponseItemService>? services { get; set; }
    //}

    //sealed class ServiceResponseItemService
    //{
    //    public string? description { get; set; }
    //    public Dictionary<string, ServiceResponseItemServiceField>? fields { get; set; }
    //}

    //sealed class ServiceResponseItemServiceField
    //{
    //    public string? description { get; set; }
    //}
    public class ServiceResponseItem
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }
        [JsonProperty("services")]
        public Dictionary<string, ServiceResponseItemService>? Services { get; set; }
    }

    public class ServiceResponseItemService
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("fields")]
        public Dictionary<string, Field>? Fields { get; set; }
    }

    public class Field
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("example")]
        [JsonConverter(typeof(CustomConverter))]
        public string Example { get; set; }
        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class Example
    {
        public string Text { get; set; }
        public int Integer { get; set; }
        public double Double { get; set; }
        public bool Boolean { get; set; }
        public Light Light { get; set; }

    }

    public class Light
    {
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("brightness")]
        public int Brightness { get; set; }
    }

    public class Service
    {
        public string Description { get; set; }
        public string ServicePath => $"{Domain}/{ServiceName}";
        public string ServicePathDisplay => $"{Domain}.{ServiceName}";
        public string Domain { get; set; }
        public string ServiceName { get; set; }
        public Dictionary<string, Field> Fields { get; set; }

        public Service(string description, string domain, string serviceName, Dictionary<string, Field> fields)
        {
            Description = description;
            Domain = domain;
            ServiceName = serviceName;
            Fields = fields;
        }

    }

    
}
