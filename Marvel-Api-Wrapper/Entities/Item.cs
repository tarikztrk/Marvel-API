using System.Text.Json.Serialization;

namespace Marvel_Api_Wrapper.Entities

{
    public class Item
    {
        [JsonPropertyName("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }


}