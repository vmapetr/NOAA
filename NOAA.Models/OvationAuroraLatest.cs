using System.Text.Json.Serialization;

namespace NOAA.Models
{
    public class OvationAuroraLatest : INOAAModel
    {
        public string GetModelUri() => "ovation_aurora_latest.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => ObservationTime;

        [JsonPropertyName("Observation Time")]
        public DateTime ObservationTime { get; set; }

        [JsonPropertyName("Forecast Time")]
        public DateTime ForecastTime { get; set; }
        
        [JsonPropertyName("Data Format")]
        public string? DataFormat { get; set; }

        [JsonPropertyName("coordinates")]
        public int[][]? Coordinates { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
