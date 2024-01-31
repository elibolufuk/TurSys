using TurSys.Application.Requests;
using TurSys.Application.Responses;

namespace TurSys.Application.Clients.Interfaces;

public interface IBusLocationClient
{
    Task<BaseDataResponse<IList<BusLocationResponse>>> GetBusLocations(BusLocationsRequest request);

}
