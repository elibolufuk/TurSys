using Newtonsoft.Json;

namespace TurSys.Application.Requests;

public record BusJourneysRequest<TData>
{
#nullable disable
    [JsonProperty("device-session")]
    public DeviceSessionRequest DeviceSession { get; set; }

    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("data")]
    public TData Data { get; set; }
#nullable restore
}
