using Newtonsoft.Json;

namespace TurSys.Application.Requests;
public record DeviceSessionRequest
{
#nullable disable
    [JsonProperty("session-id")]
    public string SessionId { get; set; }

    [JsonProperty("device-id")]
    public string DeviceId { get; set; }
#nullable restore
}
