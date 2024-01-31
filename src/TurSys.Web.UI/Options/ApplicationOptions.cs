using TurSys.Web.UI.Options.Interfaces;

namespace TurSys.Web.UI.Settings;
public class ApplicationOptions: IApplicationOptions
{
    public string? StaticVersion { get; set; }
}
