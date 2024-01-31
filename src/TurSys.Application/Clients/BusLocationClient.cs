using TurSys.Application.Clients.Interfaces;
using TurSys.Application.Constants;
using TurSys.Application.Helpers.Interfaces;
using TurSys.Application.Requests;
using TurSys.Application.Responses;

namespace TurSys.Application.Clients;

public class BusLocationClient(IHttpClientHelper httpClientHelper, IIntegrationHelper integrationHelper) : IBusLocationClient
{
    private readonly IHttpClientHelper _httpClientHelper = httpClientHelper;
    private readonly IIntegrationHelper _integrationHelper = integrationHelper;
    public async Task<BaseDataResponse<IList<BusLocationResponse>>> GetBusLocations(BusLocationsRequest request)
    {
        var apiUrl = _integrationHelper[ClientApiUrlConstants.GetBusLocations];
        if (string.IsNullOrEmpty(apiUrl))
            return new() { Status = "Error" };

        return await _httpClientHelper.PostAsync<BusLocationsRequest, BaseDataResponse<IList<BusLocationResponse>>>(apiUrl, request);
    }
}
