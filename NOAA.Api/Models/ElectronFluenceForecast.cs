using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class ElectronFluenceForecast : INOAAModel
    {
        public string GetModelUri() => "electron_fluence_forecast.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => Date;

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("speed")]
        public double? Speed { get; set; }

        [JsonPropertyName("fluence")]
        public double? Fluence { get; set; }

        [JsonPropertyName("fluence_day_two")]
        public double? FluenceDayTwo { get; set; }

        [JsonPropertyName("fluence_day_three")]
        public double? FluenceDayThree { get; set; }

        [JsonPropertyName("fluence_day_four")]
        public double? FluenceDayFour { get; set; }
    }
}
