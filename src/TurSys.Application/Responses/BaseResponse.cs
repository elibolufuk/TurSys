using Newtonsoft.Json;

namespace TurSys.Application.Responses;

public record BaseResponse
{
    #nullable disable
    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("correlation-id")]
    public string CorrelationId { get; set; }
#nullable restore

    [JsonProperty("controller")]
    public string? Controller { get; set; }

    [JsonProperty("client-request-id")]
    public object? ClientRequestId { get; set; }

    [JsonProperty("web-correlation-id")]
    public object? WebCorrelationId { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("user-message")]
    public object? UserMessage { get; set; }

    [JsonProperty("parameters")]
    public object? Parameters { get; set; }

    [JsonProperty("api-request-id")]
    public object? ApiRequestId { get; set; }

}
