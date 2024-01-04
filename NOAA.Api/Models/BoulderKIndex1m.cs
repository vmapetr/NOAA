using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class BoulderKIndex1m : INOAAModel
    {
        public string GetModelUri() => "boulder_k_index_1m.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimeTag;

        [JsonPropertyName("time_tag")]
        public DateTime TimeTag { get; set; }

        [JsonPropertyName("k_index")]
        public double? KIndex { get; set; }
    }
}
