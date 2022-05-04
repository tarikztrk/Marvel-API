using System.Text.Json.Serialization;

namespace Marvel_Api_Wrapper.Entities

{
    public class Data<T>
    {
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("results")]
        public List<T> Results { get; set; }
    }


}