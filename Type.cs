using System.Text.Json.Serialization;

namespace Pokemon_Client
{
    class Type
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("damage_relations")]
        public TypeRelations DamageRelations { get; set; }
    }
}
