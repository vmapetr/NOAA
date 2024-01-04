using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class PlanetaryKIndex1m : INOAAModel
    {
        public string GetModelUri() => "planetary_k_index_1m.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimeTag;

        [JsonPropertyName("time_tag")]
        public DateTime TimeTag { get; set; }

        [JsonPropertyName("kp_index")]
        public int? KpIndex { get; set; }

        [JsonPropertyName("estimated_kp")]
        public double? EstimatedKp { get; set; }

        [JsonPropertyName("kp")]
        public string? Kp { get; set; }
    }
}
