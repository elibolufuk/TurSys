using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TurSys.Application.Clients.Interfaces;
using TurSys.Application.Models.BusLocationModels;
using TurSys.Application.Requests;
using TurSys.Application.Responses;
using TurSys.Web.UI.Controllers.BaseControllers;

namespace TurSys.Web.UI.Controllers.ClientControllers;

public class BusLocationController(ILogger<BusLocationController> logger, IBusLocationClient busLocationClient, IMapper mapper)
    : BaseClientController<BusLocationController>(logger)
{
    private readonly IBusLocationClient _busLocationClient = busLocationClient;
    private readonly IMapper _mapper = mapper;

    [HttpPost("get-list")]
    [ProducesResponseType(typeof(BaseDataResponse<IList<BusLocationResponse>>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(BaseResponse), (int)HttpStatusCode.BadRequest)]
    public async Task<IActionResult> GetBusLocations([FromBody] GetBusLocationRequestModel model)
    {
        if (!ModelState.IsValid)
            return BadRequest(new BaseResponse
            {
                Status = HttpStatusCode.BadRequest.ToString(),
                Message = HttpStatusCode.BadRequest.ToString()
            });

        var request = _mapper.Map<BusLocationsRequest>(model);
        request.DeviceSession = new()
        {
            DeviceId = DeviceId,
            SessionId = SessionId
        };
        request.Language = Language;
        var response = await _busLocationClient.GetBusLocations(request);
        return Ok(response);
    }
}
