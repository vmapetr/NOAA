using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class PredictedMonthlySunspotNumber : INOAAModel
    {
        public string GetModelUri() => "predicted_monthly_sunspot_number.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => Date;

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("ssn_predicted")]
        public double? SsnPredicted { get; set; }

        [JsonPropertyName("ssn_high")]
        public double? SsnHigh { get; set; }

        [JsonPropertyName("ssn_low")]
        public double? SsnLow { get; set; }

        [JsonPropertyName("flux_predicted")]
        public double? FluxPredicted { get; set; }

        [JsonPropertyName("flux_high")]
        public double? FluxHigh { get; set; }

        [JsonPropertyName("flux_low")]
        public double? FluxLow { get; set; }
    }
}
