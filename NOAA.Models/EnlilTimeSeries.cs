using System.Text.Json.Serialization;

namespace NOAA.Models
{
    public class EnlilTimeSeries : INOAAModel
    {
        public string GetModelUri() => "enlil_time_series.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("time_tag")]
        public DateTime Timestamp { get; set; }
        
        [JsonPropertyName("earth_particles_per_cm3")]
        public double? EarthParticlesRerCm3 { get; set; }

        [JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        [JsonPropertyName("v_r")]
        public double? VR { get; set; }
        
        [JsonPropertyName("v_theta")]
        public double? VTheta { get; set; }

        [JsonPropertyName("v_phi")]
        public double? VPhi { get; set; }

        [JsonPropertyName("b_r")]
        public double? BR { get; set; }
        
        [JsonPropertyName("b_theta")]
        public double? BTheta { get; set; }

        [JsonPropertyName("b_phi")]
        public double? BPhi { get; set; }
        
        [JsonPropertyName("polarity")]
        public double? Polarity { get; set; }
        
        [JsonPropertyName("cloud")]
        public double? Cloud { get; set; }
    }
}
