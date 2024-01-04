using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class PredictedFredericksburgAIndex : INOAAModel
    {
        public string GetModelUri() => "predicted_fredericksburg_a_index.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => Date;

        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("afred_1_day")]
        public int? Afred1Day { get; set; }

        [JsonPropertyName("afred_2_day")]
        public int? Afred2Day { get; set; }

        [JsonPropertyName("afred_3_day")]
        public int? Afred3Day { get; set; }
    }
}
