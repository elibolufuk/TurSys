using Newtonsoft.Json;

namespace TurSys.Application.Requests;

public record BusLocationsRequest
{
#nullable disable
    [JsonProperty("data")]
    public string Data { get; set; }

    [JsonProperty("device-session")]
    public DeviceSessionRequest DeviceSession { get; set; }

    [JsonProperty("date")]
    public DateTime Date { get; set; }

    [JsonProperty("language")]
    public string Language { get; set; }
#nullable restore
}
