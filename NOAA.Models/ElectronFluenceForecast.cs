using NOAA.Models.StatisticAttributes;
using System.Text.Json.Serialization;

namespace NOAA.Models
{
    public class ElectronFluenceForecast : INOAAModel
    {
        public string GetModelUri() => "electron_fluence_forecast.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("date")]
        public DateTime Timestamp { get; set; }

        [Statistics]
        [JsonPropertyName("speed")]
        public double? Speed { get; set; }

        [Statistics]
        [JsonPropertyName("fluence")]
        public double? Fluence { get; set; }

        [Statistics]
        [JsonPropertyName("fluence_day_two")]
        public double? FluenceDayTwo { get; set; }

        [Statistics]
        [JsonPropertyName("fluence_day_three")]
        public double? FluenceDayThree { get; set; }

        [Statistics]
        [JsonPropertyName("fluence_day_four")]
        public double? FluenceDayFour { get; set; }
    }
}
