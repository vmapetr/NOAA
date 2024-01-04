using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class F107CmFlux : INOAAModel
    {
        public string GetModelUri() => "f107_cm_flux.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => TimeTag;

        [JsonPropertyName("time_tag")]
        public DateTime TimeTag { get; set; }
        
        [JsonPropertyName("frequency")]
        public int? Frequency { get; set; }
        
        [JsonPropertyName("flux")]
        public double? Flux { get; set; }
        
        [JsonPropertyName("reporting_schedule")]
        public string? ReportingSchedule { get; set; }

        [JsonPropertyName("avg_begin_date")]
        public DateTime? AvgBeginDate { get; set; }
        
        [JsonPropertyName("ninety_day_mean")]
        public double? NinetyDayMean { get; set; }
        
        [JsonPropertyName("rec_count")]
        public int? RecCount { get; set; }
    }
}
