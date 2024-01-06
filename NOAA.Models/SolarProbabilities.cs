using System.Text.Json.Serialization;

namespace NOAA.Models
{
    public class SolarProbabilities : INOAAModel
    {
        public string GetModelUri() => "solar_probabilities.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("date")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("c_class_1_day")]
        public int? CClass1Day { get; set; }

        [JsonPropertyName("c_class_2_day")]
        public int? CClass2Day { get; set; }

        [JsonPropertyName("c_class_3_day")]
        public int? CClass3Day { get; set; }

        [JsonPropertyName("m_class_1_day")]
        public int? MClass1Day { get; set; }

        [JsonPropertyName("m_class_2_day")]
        public int? MClass2Day { get; set; }

        [JsonPropertyName("m_class_3_day")]
        public int? MClass3Day { get; set; }

        [JsonPropertyName("x_class_1_day")]
        public int? XClass1Day { get; set; }

        [JsonPropertyName("x_class_2_day")]
        public int? XClass2Day { get; set; }

        [JsonPropertyName("x_class_3_day")]
        public int? XClass3Day { get; set; }

        [JsonPropertyName("10mev_protons_1_day")]
        public int? TenMevProtons1Day { get; set; }

        [JsonPropertyName("10mev_protons_2_day")]
        public int? TenMevProtons2Day { get; set; }

        [JsonPropertyName("10mev_protons_3_day")]
        public int? TenMevProtons3Day { get; set; }

        [JsonPropertyName("polar_cap_absorption")]
        public string? PolarCapAbsorption { get; set; }
    }
}
