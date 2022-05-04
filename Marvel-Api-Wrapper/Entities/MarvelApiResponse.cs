using System.Text.Json.Serialization;

namespace Marvel_Api_Wrapper.Entities

{
    public class MarvelApiResponse<T>
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("attributionText")]
        public string AttributionText { get; set; }

        [JsonPropertyName("attributionHTML")]
        public string AttributionHTML { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("data")]
        public Data<T> Data { get; set; }
    }


}