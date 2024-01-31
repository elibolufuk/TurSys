using Newtonsoft.Json;

namespace TurSys.Application.Responses;

public record BusLocationResponse
{
#nullable disable
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("parent-id")]
    public int ParentId { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("geo-location")]
    public GeoLocationResponse GeoLocation { get; set; }

    [JsonProperty("zoom")]
    public int Zoom { get; set; }

    [JsonProperty("tz-code")]
    public string TimeZoneCode { get; set; }

    [JsonProperty("weather-code")]
    public object WeatherCode { get; set; }

    [JsonProperty("rank")]
    public int Rank { get; set; }

    [JsonProperty("reference-code")]
    public string ReferenceCode { get; set; }

    [JsonProperty("city-id")]
    public int CityId { get; set; }

    [JsonProperty("reference-country")]
    public object ReferenceCountry { get; set; }

    [JsonProperty("country-id")]
    public int CountryId { get; set; }

    [JsonProperty("keywords")]
    public string Keywords { get; set; }

    [JsonProperty("city-name")]
    public string CityName { get; set; }

    [JsonProperty("languages")]
    public object Languages { get; set; }

    [JsonProperty("country-name")]
    public string CountryName { get; set; }

    [JsonProperty("code")]
    public object Code { get; set; }

    [JsonProperty("show-country")]
    public bool ShowCountry { get; set; }

    [JsonProperty("area-code")]
    public object AreaCode { get; set; }

    [JsonProperty("long-name")]
    public string LongName { get; set; }

    [JsonProperty("is-city-center")]
    public bool IsCityCenter { get; set; }

    public record GeoLocationResponse
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("zoom")]
        public int Zoom { get; set; }
    }
#nullable restore
}
