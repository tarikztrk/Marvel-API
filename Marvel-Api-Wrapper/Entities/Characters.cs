using System.Text.Json.Serialization;

namespace Marvel_Api_Wrapper.Entities

{
    public class Characters
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("modified")]
        public string Modified { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonPropertyName("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonPropertyName("comics")]
        public Comics Comics { get; set; }

        [JsonPropertyName("series")]
        public Series Series { get; set; }

        [JsonPropertyName("stories")]
        public Stories Stories { get; set; }

        [JsonPropertyName("events")]
        public Events Events { get; set; }

        [JsonPropertyName("urls")]
        public List<Url> Urls { get; set; }
    }


}