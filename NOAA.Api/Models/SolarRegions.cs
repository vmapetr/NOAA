using System.Text.Json.Serialization;

namespace NOAA.Api.Models
{
    public class SolarRegions : INOAAModel
    {
        public string GetModelUri() => "solar_regions.json";

        [JsonIgnore]
        public long HashCode { get => FirstDate.Ticks + Location.GetHashCode(); }

        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public DateTime Timestamp => ObservedDate;

        [JsonPropertyName("observed_date")]
        public DateTime ObservedDate { get; set; }

        [JsonPropertyName("region")]
        public int? Region { get; set; }

        [JsonPropertyName("latitude")]
        public int? Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public int? Longitude { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; } = string.Empty;

        [JsonPropertyName("carrington_longitude")]
        public int? CarringtonLongitude { get; set; }

        [JsonPropertyName("old_carrington_longitude")]
        public int? OldCarringtonLongitude { get; set; }

        [JsonPropertyName("area")]
        public int? Area { get; set; }

        [JsonPropertyName("spot_class")]
        public string? SpotClass { get; set; }

        [JsonPropertyName("extent")]
        public int? Extent { get; set; }

        [JsonPropertyName("number_spots")]
        public int? NumberSpots { get; set; }

        [JsonPropertyName("mag_class")]
        public string? MagClass { get; set; }

        [JsonPropertyName("mag_string")]
        public string? MagString { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("c_xray_events")]
        public int? CXrayEvents { get; set; }

        [JsonPropertyName("m_xray_events")]
        public int? MXrayEvents { get; set; }

        [JsonPropertyName("x_xray_events")]
        public int? XXrayEvents { get; set; }

        [JsonPropertyName("proton_events")]
        public int? ProtonEvents { get; set; }

        [JsonPropertyName("s_flares")]
        public int? SFlares { get; set; }

        [JsonPropertyName("impulse_flares_1")]
        public int? ImpulseFlares1 { get; set; }

        [JsonPropertyName("impulse_flares_2")]
        public int? ImpulseFlares2 { get; set; }

        [JsonPropertyName("impulse_flares_3")]
        public int? ImpulseFlares3 { get; set; }

        [JsonPropertyName("impulse_flares_4")]
        public int? ImpulseFlares4 { get; set; }

        [JsonPropertyName("protons")]
        public int? Protons { get; set; }

        [JsonPropertyName("c_flare_probability")]
        public int? CFlareProbability { get; set; }

        [JsonPropertyName("m_flare_probability")]
        public int? MFlareProbability { get; set; }

        [JsonPropertyName("x_flare_probability")]
        public int? XFlareProbability { get; set; }

        [JsonPropertyName("proton_probability")]
        public int? ProtonProbability { get; set; }

        [JsonPropertyName("first_date")]
        public DateTime FirstDate { get; set; }
    }
}
