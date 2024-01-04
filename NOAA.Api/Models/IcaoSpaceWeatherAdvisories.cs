using System.Globalization;
using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class IcaoSpaceWeatherAdvisories : INOAAModel
    {
        public string GetModelUri() => "icao-space-weather-advisories.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => DateTag;

        [JsonPropertyName("dtg")]
        public string? Dtg { get; set; }

        [JsonIgnore]
        public DateTime DateTag   // <=============== Z symbol, +1h offset?
        {
            get 
            {
                if (DateTime.TryParseExact(Dtg?.Trim('Z'), "yyyyMMdd/HHmm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                {
                    return date;
                }

                return default(DateTime);
            }
        }

        [JsonPropertyName("advisoryId")]
        public int? AdvisoryId { get; set; }

        [JsonPropertyName("advisoryNumber")]
        public string? AdvisoryNumber { get; set; }

        [JsonPropertyName("swxEffect")]
        public string? SwxEffect { get; set; }

        [JsonPropertyName("severity")]
        public string? Severity { get; set; }

        [JsonPropertyName("obsSwx")]
        public string? ObsSwx { get; set; }

        [JsonPropertyName("expiration")]
        public DateTime Expiration { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("tac")]
        public string? Tac { get; set; }
    }
}
