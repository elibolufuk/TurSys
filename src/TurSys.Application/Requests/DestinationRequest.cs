using Newtonsoft.Json;

namespace TurSys.Application.Requests;

public record DestinationRequest
{
#nullable disable
    [JsonProperty("origin-id")]
    public int Originid { get; set; }

    [JsonProperty("destination-id")]
    public int Destinationid { get; set; }

    [JsonProperty("departure-date")]
    public string Departuredate { get; set; }
#nullable restore
}
