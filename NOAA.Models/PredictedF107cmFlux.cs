using System.Text.Json.Serialization;

namespace NOAA.Models
{
    public class PredictedF107cmFlux : INOAAModel
    {
        public string GetModelUri() => "predicted_f107cm_flux.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("date")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("tencmfcst_1_day")]
        public int? Tencmfcst1Day { get; set; }

        [JsonPropertyName("tencmfcst_2_day")]
        public int? Tencmfcst2Day { get; set; }

        [JsonPropertyName("tencmfcst_3_day")]
        public int? Tencmfcst3Day { get; set; }
    }
}
