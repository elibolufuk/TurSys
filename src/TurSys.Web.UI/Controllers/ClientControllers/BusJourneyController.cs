using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;
using TurSys.Application.Clients.Interfaces;
using TurSys.Application.Models.BusJourneyModels;
using TurSys.Application.Requests;
using TurSys.Application.Responses;
using TurSys.Web.UI.Controllers.BaseControllers;

namespace TurSys.Web.UI.Controllers.ClientControllers;

public class BusJourneyController(ILogger<HomeController> logger, IBusJourneyClient busJourneyClient, IMapper mapper)
    : BaseClientController<HomeController>(logger)
{
    private readonly IBusJourneyClient _busJourneyClient = busJourneyClient;
    private readonly IMapper _mapper = mapper;

    [HttpPost("get-list")]

    [ProducesResponseType(typeof(BaseDataResponse<List<BusJourneyResponse>>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(BaseResponse), (int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> GetBusJourneys([FromBody] GetListBusJourneyRequestModel model, string message)
    {
        if (!ModelState.IsValid)
            return BadRequest(new BaseResponse
            {
                Status = HttpStatusCode.BadRequest.ToString(),
                Message = HttpStatusCode.BadRequest.ToString()
            });

        var request = _mapper.Map<BusJourneysRequest<DestinationRequest>>(model);
        request.DeviceSession = new()
        {
            DeviceId = DeviceId,
            SessionId = SessionId
        };
        request.Language = Language;

        var response = await _busJourneyClient.GetBusJourneys(request);
#pragma warning disable CA2253 // Named placeholders should not be numeric values
        Logger.LogInformation("Method : {0} , Request : {1}", nameof(GetBusJourneys), JsonSerializer.Serialize(request));
#pragma warning restore CA2253 // Named placeholders should not be numeric values
        return Ok(response);
    }
}