using NOAA.Models.StatisticAttributes;
using System.Text.Json.Serialization;

namespace NOAA.Models
{
    public class PredictedMonthlySunspotNumber : INOAAModel
    {
        public string GetModelUri() => "predicted_monthly_sunspot_number.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("date")]
        public DateTime Timestamp { get; set; }

        [Statistics]
        [JsonPropertyName("ssn_predicted")]
        public double? SsnPredicted { get; set; }

        [Statistics]
        [JsonPropertyName("ssn_high")]
        public double? SsnHigh { get; set; }

        [Statistics]
        [JsonPropertyName("ssn_low")]
        public double? SsnLow { get; set; }

        [Statistics]
        [JsonPropertyName("flux_predicted")]
        public double? FluxPredicted { get; set; }

        [Statistics]
        [JsonPropertyName("flux_high")]
        public double? FluxHigh { get; set; }

        [Statistics]
        [JsonPropertyName("flux_low")]
        public double? FluxLow { get; set; }
    }
}
