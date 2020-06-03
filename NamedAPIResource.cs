using System.Text.Json.Serialization;

namespace Pokemon_Client
{
    class NamedAPIResource
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
