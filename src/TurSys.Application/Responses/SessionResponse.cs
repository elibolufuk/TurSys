using Newtonsoft.Json;

namespace TurSys.Application.Responses;

public record SessionResponse
{
#nullable disable
    [JsonProperty("session-id")]
    public string SessionId { get; set; }

    [JsonProperty("device-id")]
    public string DeviceId { get; set; }

    [JsonProperty("device-type")]
    public int DeviceType { get; set; }

    [JsonProperty("ip-country")]
    public string IpCountry { get; set; }
#nullable restore

    [JsonProperty("affiliate")]
    public object? Affiliate { get; set; }

    [JsonProperty("device")]
    public object? Device { get; set; }
}
