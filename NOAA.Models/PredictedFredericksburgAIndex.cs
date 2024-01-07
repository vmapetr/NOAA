using NOAA.Models.StatisticAttributes;
using System.Text.Json.Serialization;

namespace NOAA.Models
{
    public class PredictedFredericksburgAIndex : INOAAModel
    {
        public string GetModelUri() => "predicted_fredericksburg_a_index.json";

        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("date")]
        public DateTime Timestamp { get; set; }

        [Statistics]
        [JsonPropertyName("afred_1_day")]
        public int? Afred1Day { get; set; }

        [Statistics]
        [JsonPropertyName("afred_2_day")]
        public int? Afred2Day { get; set; }

        [Statistics]
        [JsonPropertyName("afred_3_day")]
        public int? Afred3Day { get; set; }
    }
}
