using NOAA.Models.StatisticAttributes;
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

        [Statistics]
        [JsonPropertyName("tencmfcst_1_day")]
        public int? Tencmfcst1Day { get; set; }

        [Statistics]
        [JsonPropertyName("tencmfcst_2_day")]
        public int? Tencmfcst2Day { get; set; }

        [Statistics]
        [JsonPropertyName("tencmfcst_3_day")]
        public int? Tencmfcst3Day { get; set; }
    }
}
