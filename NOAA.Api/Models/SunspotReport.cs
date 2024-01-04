using System.Globalization;
using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class SunspotReport : INOAAModel
    {
        public string GetModelUri() => "sunspot_report.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimeTag;

        [JsonPropertyName("time_tag")]
        public DateTime TimeTag { get; set; }
        
        [JsonPropertyName("Obsdate")]
        public DateTime Obsdate { get; set; }

        [JsonPropertyName("Obstime")]
        public string? Obstime { get; set; }

        [JsonIgnore]
        public DateTime ObservationTime 
        {
            get 
            {
                if (Obsdate != default(DateTime) && TimeSpan.TryParseExact(Obstime, "hhmm", CultureInfo.InvariantCulture, out TimeSpan time))
                {
                    return Obsdate + time;
                }

                return default(DateTime);
            } 
        }

        [JsonPropertyName("Station")]
        public int? Station { get; set; }
        
        [JsonPropertyName("Observatory")]
        public string? Observatory { get; set; }
        
        [JsonPropertyName("Type")]
        public string? Type { get; set; }

        [JsonPropertyName("Quality")]
        public int? Quality { get; set; }

        [JsonPropertyName("Region")]
        public int? Region { get; set; }

        [JsonPropertyName("Latitude")]
        public int? Latitude { get; set; }

        [JsonPropertyName("Report_Longitude")]
        public int? ReportLongitude { get; set; }

        [JsonPropertyName("Longitude")]
        public int? Longitude { get; set; }

        [JsonPropertyName("Report_Location")]
        public string? ReportLocation { get; set; }

        [JsonPropertyName("Location")]
        public string? Location { get; set; }

        [JsonPropertyName("Carlon")]
        public int? Carlon { get; set; }

        [JsonPropertyName("Extent")]
        public int? Extent { get; set; }

        [JsonPropertyName("Area")]
        public int? Area { get; set; }

        [JsonPropertyName("Numspot")]
        public int? Numspot { get; set; }

        [JsonPropertyName("Zurich")]
        public int? Zurich { get; set; }

        [JsonPropertyName("Penumbra")]
        public int? Penumbra { get; set; }

        [JsonPropertyName("Compact")]
        public int? Compact { get; set; }

        [JsonPropertyName("Spotclass")]
        public string? Spotclass { get; set; }

        [JsonPropertyName("Magcode")]
        public int? Magcode { get; set; }

        [JsonPropertyName("Magclass")]
        public string? Magclass { get; set; }

        [JsonPropertyName("Obsid")]
        public int? Obsid { get; set; }

        [JsonPropertyName("Report_Status")]
        public int? ReportStatus { get; set; }

        [JsonPropertyName("ValidSpotClass")]
        public int? ValidSpotClass { get; set; }
    }
}
