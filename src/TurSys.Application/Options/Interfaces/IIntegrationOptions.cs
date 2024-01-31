using static TurSys.Application.Options.IntegrationOptions;

namespace TurSys.Application.Options.Interfaces;

public interface IIntegrationOptions
{
#nullable disable
    public string Name { get; set; }
    public string BaseAddress { get; set; }
    public IList<HeaderItemOptions> Headers { get; set; }
    public SessionOptions Session { get; set; }
    public IList<ApisOptions> Apis { get; set; }
#nullable restore
}
