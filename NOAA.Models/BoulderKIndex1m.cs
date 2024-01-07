using NOAA.Models.StatisticAttributes;
using System.Text.Json.Serialization;

namespace NOAA.Models
{
    public class BoulderKIndex1m : INOAAModel
    {
        public string GetModelUri() => "boulder_k_index_1m.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("time_tag")]
        public DateTime Timestamp { get; set; }

        [Statistics]
        [JsonPropertyName("k_index")]
        public double? KIndex { get; set; }
    }
}
