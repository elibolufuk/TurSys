using Newtonsoft.Json;

namespace TurSys.Application.Responses;
public record BaseDataResponse<T> : BaseResponse
{
#nullable disable

    [JsonProperty("data")]
    public T Data { get; set; }

#nullable restore


}
