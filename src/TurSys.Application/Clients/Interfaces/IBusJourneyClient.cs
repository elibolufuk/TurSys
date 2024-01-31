using TurSys.Application.Requests;
using TurSys.Application.Responses;

namespace TurSys.Application.Clients.Interfaces;

public interface IBusJourneyClient
{
    Task<BaseDataResponse<IList<BusJourneyResponse>>> GetBusJourneys(BusJourneysRequest<DestinationRequest> request);
}
