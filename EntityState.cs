using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeAssistantShortcuts
{
    public class EntityState
    {
        [JsonProperty("entity_id")]
        public string EntityId { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("attributes")]
        public ExpandoObject Attributes { get; set; }
        [JsonProperty("last_changed")]
        public DateTime LastChanged { get; set; }
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        public string Domain => EntityId.Split('.')[0];
    }
}
