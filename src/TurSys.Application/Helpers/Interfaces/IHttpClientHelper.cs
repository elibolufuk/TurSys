namespace TurSys.Application.Helpers.Interfaces;

public interface IHttpClientHelper
{
    Task<TResponse> PostAsync<TRequest, TResponse>(string apiUrl, TRequest request);
}
