using TurSys.Application.Clients.Interfaces;
using TurSys.Application.Constants;
using TurSys.Application.Helpers.Interfaces;
using TurSys.Application.Requests;
using TurSys.Application.Responses;

namespace TurSys.Application.Clients;

internal class BusJourneyClient(IHttpClientHelper httpClientHelper, IIntegrationHelper integrationHelper) : IBusJourneyClient
{
    private readonly IHttpClientHelper _httpClientHelper = httpClientHelper;
    private readonly IIntegrationHelper _integrationHelper = integrationHelper;
    public async Task<BaseDataResponse<IList<BusJourneyResponse>>> GetBusJourneys(BusJourneysRequest<DestinationRequest> request)
    {
        var apiUrl = _integrationHelper[ClientApiUrlConstants.GetBusJourneys];
        if (string.IsNullOrEmpty(apiUrl))
            return new() { Status = "Error" };

        return await _httpClientHelper.PostAsync<BusJourneysRequest<DestinationRequest>, BaseDataResponse<IList<BusJourneyResponse>>>(apiUrl, request);
    }
}
