using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HomeAssistantShortcuts.Helper
{
    public class CustomConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); // not covered here

        }
        // A value can be either single string or object
        // Return a TextProperty in both cases
        
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var token = JToken.Load(reader);

            return token.ToString();

            //if (token == JsonToken.StartArray)
            //{
            //    var array = JArray.Load(reader);
            //    return new JsonTestResultArray(array);
            //}

            var item = JObject.Load(reader);
            //var jObject = JToken.ReadFrom(reader);


            return item;

        }

        public override bool CanConvert(Type objectType) => false;


        // Skipped WriteJson and CanConvert
    }

    public class CustomConverterAttribute : Attribute
    {

    }

}
