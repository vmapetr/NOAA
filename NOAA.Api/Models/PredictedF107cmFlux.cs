using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class PredictedF107cmFlux : INOAAModel
    {
        public string GetModelUri() => "predicted_f107cm_flux.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => Date;

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("tencmfcst_1_day")]
        public int? Tencmfcst1Day { get; set; }

        [JsonPropertyName("tencmfcst_2_day")]
        public int? Tencmfcst2Day { get; set; }

        [JsonPropertyName("tencmfcst_3_day")]
        public int? Tencmfcst3Day { get; set; }
    }
}
