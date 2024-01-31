using TurSys.Application.Options.Interfaces;

namespace TurSys.Application.Options;
#nullable disable
public class IntegrationOptions : IIntegrationOptions
{
    public string Name { get; set; }
    public string BaseAddress { get; set; }
    public IList<HeaderItemOptions> Headers { get; set; }
    public SessionOptions Session { get; set; }
    public IList<ApisOptions> Apis { get; set; }

    public class HeaderItemOptions
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class ApisOptions
    {
        public string Key { get; set; }
        public string Url { get; set; }
    }
}

public class SessionOptions
{
    public int Type { get; set; }
    public SessionConnectionOptions Connection { get; set; }
    public SessionBrowserOptions Browser { get; set; }

    public class SessionConnectionOptions
    {
        public string IpAddress { get; set; }
        public string Port { get; set; }
    }
    public class SessionBrowserOptions
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }
}
#nullable restore