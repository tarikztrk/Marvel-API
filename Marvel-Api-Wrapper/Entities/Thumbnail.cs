using System.Text.Json.Serialization;

namespace Marvel_Api_Wrapper.Entities

{
    public class Thumbnail
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("extension")]
        public string Extension { get; set; }
    }


}