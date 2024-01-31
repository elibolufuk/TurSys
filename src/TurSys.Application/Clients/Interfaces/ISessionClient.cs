using TurSys.Application.Responses;

namespace TurSys.Application.Clients.Interfaces;

public interface ISessionClient
{
    Task<BaseDataResponse<SessionResponse>> GetSession();
}
