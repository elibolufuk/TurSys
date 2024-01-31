using Newtonsoft.Json;
using System.Text;
using TurSys.Application.Helpers.Interfaces;
using TurSys.Application.Options.Interfaces;

namespace TurSys.Application.Helpers;

public sealed class HttpClientHelper(IHttpClientFactory httpClient, IIntegrationOptions integrationOptions) : IHttpClientHelper
{
    private readonly IHttpClientFactory _httpClient = httpClient;
    private readonly IIntegrationOptions _integrationOptions = integrationOptions;
    public async Task<TResponse> PostAsync<TRequest, TResponse>(string apiUrl, TRequest request)
    {
        var result = default(TResponse);
        using (var client = _httpClient.CreateClient(_integrationOptions.Name))
        {
            _integrationOptions.Headers.ToList().ForEach(header =>
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);
            });

            var jsonContent = JsonConvert.SerializeObject(request).ToString();
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            using var response = await client.PostAsync(apiUrl, content);
            var data = await response.Content.ReadAsStringAsync();
            result = JsonConvert.DeserializeObject<TResponse>(data);
        }
#nullable disable
        return result;
#nullable restore
    }
}
