using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TurSys.Application.Clients;
using TurSys.Application.Clients.Interfaces;
using TurSys.Application.Helpers;
using TurSys.Application.Helpers.Interfaces;
using TurSys.Application.Options;
using TurSys.Application.Options.Interfaces;

namespace TurSys.Application.Extensions;
public static class ConfigurationExtensions
{
    public static IServiceCollection AddApplicationServiceCollections(this IServiceCollection services, IConfigurationManager configuration)
    {
        var integrationOptions = new IntegrationOptions();
        configuration.GetSection(nameof(IntegrationOptions)).Bind(integrationOptions);
        services.AddSingleton<IIntegrationOptions>(integrationOptions);
        services.AddHttpClient(integrationOptions.Name, c => { c.BaseAddress = new Uri(integrationOptions.BaseAddress); });

        services.AddScoped<IHttpClientHelper, HttpClientHelper>();
        services.AddScoped<ISessionClient, SessionClient>();
        services.AddScoped<IBusJourneyClient, BusJourneyClient>();
        services.AddScoped<IBusLocationClient, BusLocationClient>();

        services.AddScoped<IIntegrationHelper, IntegrationHelper>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}