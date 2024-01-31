using TurSys.Application.Clients.Interfaces;
using TurSys.Application.Helpers.Interfaces;
using TurSys.Application.Responses;
using TurSys.Application.Options.Interfaces;
using TurSys.Application.Requests;
using TurSys.Application.Constants;

namespace TurSys.Application.Clients;

public class SessionClient(IHttpClientHelper httpClientHelper, IIntegrationOptions integrationOptions, IIntegrationHelper integrationHelper)
    : ISessionClient
{
    private readonly IHttpClientHelper _httpClientHelper = httpClientHelper;
    private readonly IIntegrationOptions _integrationOptions = integrationOptions;
    private readonly IIntegrationHelper _integrationHelper = integrationHelper;
    public async Task<BaseDataResponse<SessionResponse>> GetSession()
    {
        var apiUrl = _integrationHelper[ClientApiUrlConstants.GetSession];
        if (string.IsNullOrEmpty(apiUrl))
            return new()
            {
                Status = "Error"
            };

        var session = await _httpClientHelper.PostAsync<SessionRequest, BaseDataResponse<SessionResponse>>(apiUrl, new()
        {
            Type = _integrationOptions.Session.Type,
            Connection = new()
            {
                IpAddress = _integrationOptions.Session.Connection.IpAddress,
                Port = _integrationOptions.Session.Connection.Port
            },
            Browser = new()
            {
                Name = _integrationOptions.Session.Browser.Name,
                Version = _integrationOptions.Session.Browser.Version
            }
        });

        return session;
    }
}
