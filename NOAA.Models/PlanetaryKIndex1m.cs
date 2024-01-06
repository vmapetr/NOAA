using System.Text.Json.Serialization;

namespace NOAA.Models
{
    public class PlanetaryKIndex1m : INOAAModel
    {
        public string GetModelUri() => "planetary_k_index_1m.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("time_tag")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("kp_index")]
        public int? KpIndex { get; set; }

        [JsonPropertyName("estimated_kp")]
        public double? EstimatedKp { get; set; }

        [JsonPropertyName("kp")]
        public string? Kp { get; set; }
    }
}
