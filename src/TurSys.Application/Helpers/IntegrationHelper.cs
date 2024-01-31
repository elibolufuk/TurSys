using TurSys.Application.Helpers.Interfaces;
using TurSys.Application.Options.Interfaces;

namespace TurSys.Application.Helpers;

public class IntegrationHelper(IIntegrationOptions integrationOptions) : IIntegrationHelper
{
    private readonly IIntegrationOptions _integrationOptions = integrationOptions;
    public string this[string key]
        => GetUrlByKey(key);

    private string GetUrlByKey(string key)
    {
        var api = _integrationOptions.Apis.Where(x => x.Key == key).FirstOrDefault();
        if (api == null)
            return "";

        return api.Url;
    }

}
