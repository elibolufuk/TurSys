using Newtonsoft.Json;

namespace TurSys.Application.Requests;

public record SessionRequest
{
#nullable disable
    [JsonProperty("type")]
    public int Type { get; set; }

    [JsonProperty("connection")]
    public ConnectionRequest Connection { get; set; }

    [JsonProperty("browser")]
    public BrowserRequest Browser { get; set; }

    public record ConnectionRequest
    {

        [JsonProperty("ip-address")]
        public string IpAddress { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }
    }

    public record BrowserRequest
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
#nullable restore
}
