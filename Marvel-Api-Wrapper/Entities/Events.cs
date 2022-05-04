using System.Text.Json.Serialization;

namespace Marvel_Api_Wrapper.Entities

{
    public class Events
    {
        [JsonPropertyName("available")]
        public int Available { get; set; }

        [JsonPropertyName("collectionURI")]
        public string CollectionURI { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("returned")]
        public int Returned { get; set; }
    }


}