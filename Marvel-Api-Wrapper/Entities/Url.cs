using System.Text.Json.Serialization;

namespace Marvel_Api_Wrapper.Entities

{
    public class Url
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("url")]
        public string Href { get; set; }
    }


}