using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class EditedEvents : INOAAModel
    {
        public string GetModelUri() => "edited_events.json";

        [JsonIgnore]
        public long HashCode 
        {
            get
            {
                return  BeginDatetime.Ticks + 
                        MaxDatetime.Ticks + 
                        EndDatetime.Ticks + 
                        Observatory.GetHashCode() + 
                        Type.GetHashCode() + 
                        StatusCode;
            }
        }

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => BeginDatetime;

        [JsonPropertyName("begin_datetime")]
        public DateTime BeginDatetime { get; set; }

        [JsonPropertyName("begin_quality")]
        public string? BeginQuality { get; set; }

        [JsonPropertyName("max_datetime")]
        public DateTime MaxDatetime { get; set; }

        [JsonPropertyName("max_quality")]
        public string? MaxQuality { get; set; }

        [JsonPropertyName("end_datetime")]
        public DateTime EndDatetime { get; set; }

        [JsonPropertyName("end_quality")]
        public string? EndQuality { get; set; }

        [JsonPropertyName("observatory")]
        public string Observatory { get; set; } = string.Empty;

        [JsonPropertyName("quality")]
        public string? Quality { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("coded_type")]
        public int? CodedType { get; set; }

        [JsonPropertyName("obsid")]
        public int? Obsid { get; set; }

        [JsonPropertyName("location")]
        public string? Location { get; set; }

        [JsonPropertyName("frequency")]
        public string? Frequency { get; set; }

        [JsonPropertyName("particulars1")]
        public string? Particulars1 { get; set; }

        [JsonPropertyName("particulars2")]
        public string? Particulars2 { get; set; }

        [JsonPropertyName("particulars3")]
        public string? Particulars3 { get; set; }

        [JsonPropertyName("particulars4")]
        public string? Particulars4 { get; set; }

        [JsonPropertyName("particulars5")]
        public string? Particulars5 { get; set; }

        [JsonPropertyName("particulars6")]
        public string? Particulars6 { get; set; }

        [JsonPropertyName("particulars7")]
        public string? Particulars7 { get; set; }

        [JsonPropertyName("particulars8")]
        public string? Particulars8 { get; set; }

        [JsonPropertyName("particulars9")]
        public string? Particulars9 { get; set; }

        [JsonPropertyName("particulars10")]
        public string? Particulars10 { get; set; }

        [JsonPropertyName("region")]
        public int? Region { get; set; }

        [JsonPropertyName("bin")]
        public int? Bin { get; set; }

        [JsonPropertyName("age")]                           // Presumably INT, unknown type
        public int? Age { get; set; }

        [JsonPropertyName("status_code")]
        public int StatusCode { get; set; }

        [JsonPropertyName("status_text")]
        public string? StatusText { get; set; }

        [JsonPropertyName("change_flag")]
        public int? ChangeFlag { get; set; }
    }
}
