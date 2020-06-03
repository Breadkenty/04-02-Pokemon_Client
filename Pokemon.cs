using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pokemon_Client
{
    class Pokemon
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

    }
}
