using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pokemon_Client
{
    class TypeRelations
    {
        [JsonPropertyName("no_damage_to")]
        public List<NamedAPIResource> NoDamageTo { get; set; }

        [JsonPropertyName("double_damage_to")]
        public List<NamedAPIResource> DoubleDamageTo { get; set; }

        [JsonPropertyName("no_damage_from")]
        public List<NamedAPIResource> NoDamageFrom { get; set; }

        [JsonPropertyName("double_damage_from")]
        public List<NamedAPIResource> DoubleDamageFrom { get; set; }
    }
}
