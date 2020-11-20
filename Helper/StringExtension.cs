using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HomeAssistantShortcuts.Helper
{
    static class StringExtension
    {
        public static bool IsValidJson(this string stringValue)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
            {
                return false;
            }

            var value = stringValue.Trim();

            if ((value.StartsWith("{") && value.EndsWith("}")) || //For object
                (value.StartsWith("[") && value.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(value);
                    return true;
                }
                catch (JsonReaderException)
                {
                    return false;
                }
            }

            return false;
        }

        public static KeyValuePair<bool, string> IsValidWithError(this string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return new KeyValuePair<bool, string>(false, "Empty string");
            }

            var value = json.Trim();

            if ((value.StartsWith("{") && value.EndsWith("}")) || //For object
                (value.StartsWith("[") && value.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(value);
                    return new KeyValuePair<bool, string>(true, string.Empty);
                }
                catch (JsonReaderException ex)
                {
                    return new KeyValuePair<bool, string>(false, ex.Message);
                }
            }

            return new KeyValuePair<bool, string>(false, "Empty string");
        }

        public static string BeautifieJsonString(this string json)
        {
            if(!json.IsValidJson()) return json;
            var parsedJson = JToken.Parse(json);
            return parsedJson.ToString(Formatting.Indented);

        }
    }
}
