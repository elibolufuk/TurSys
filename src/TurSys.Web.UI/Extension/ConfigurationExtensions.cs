using Microsoft.Extensions.Options;
using TurSys.Web.UI.Options.Interfaces;
using TurSys.Web.UI.Settings;

namespace TurSys.Web.UI.Extension;

public static class ConfigurationExtensions
{
    public static IServiceCollection AddServiceCollections(this IServiceCollection services, IConfigurationManager configuration)
    {
        services.Configure<ApplicationOptions>(configuration.GetSection(nameof(ApplicationOptions)));
        services.AddSingleton<IApplicationOptions>(x => x.GetRequiredService<IOptions<ApplicationOptions>>().Value);
        return services;
    }
}