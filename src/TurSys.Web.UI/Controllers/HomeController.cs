using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using TurSys.Application.Clients.Interfaces;
using TurSys.Application.Requests;
using TurSys.Web.UI.Controllers.BaseControllers;
using TurSys.Web.UI.Extension;
using TurSys.Web.UI.Models;
using TurSys.Web.UI.Models.BaseModels;
using TurSys.Web.UI.Models.TicketModels;

namespace TurSys.Web.UI.Controllers;

public class HomeController(ILogger<HomeController> logger, IBusJourneyClient busJourneyClient)
    : BaseController<HomeController>(logger)
{
    private readonly IBusJourneyClient _busJourneyClient = busJourneyClient;

    public IActionResult Index()
    {
        Logger.LogInformation("Home start");
        return View();
    }

    [HttpGet("tickets")]
    public async Task<IActionResult> Tickets([FromQuery] TicketPostModel postModel)
    {
        if (!ModelState.IsValid)
            return View(new BaseViewModel
            {
                Status = "Error",
                Message = "Validasyon hatası"
            });

        var request = new BusJourneysRequest<DestinationRequest>
        {
            Language = base.Language,
            Data = new()
            {
                Departuredate = postModel.Departuredate,
                Destinationid = postModel.Destinationid,
                Originid = postModel.Originid
            },
            DeviceSession = new()
            {
                DeviceId = base.DeviceId,
                SessionId = base.SessionId
            }
        };

#pragma warning disable CA2253 // Named placeholders should not be numeric values
        base.Logger.LogInformation("Method : {0} , Request : {1}", nameof(Tickets), JsonSerializer.Serialize(request));
#pragma warning restore CA2253 // Named placeholders should not be numeric values
        var result = await _busJourneyClient.GetBusJourneys(request);

        var response = new TicketViewModel
        {
            Date = postModel.Departuredate.ConvertTextToDate('-'),
            Destination = (result.Data?.Count > 0 ? result.Data?[0].Journey.Destination : ""),
            Origin = (result.Data?.Count > 0 ? result.Data?[0].Journey.Origin : ""),
            DestinationId = postModel.Destinationid,
            OriginId = postModel.Originid,
            Response = new BaseViewDataModel<IList<TicketViewDataModel>>
            {
                Data = (result.Data?.Count > 0 ? result.Data?.Select(x => new TicketViewDataModel
                {
                    Journey = x.Journey,
                    OriginLocation = x.OriginLocation,
                    AvailableSeats = x.AvailableSeats,
                    BusType = x.BusType,
                    BusTypeName = x.BusTypeName,
                    DestinationLocation = x.DestinationLocation,
                    Id = x.Id,
                    IsActive = x.IsActive,
                    PartnerId = x.PartnerId,
                    PartnerName = x.PartnerName,
                    RouteId = x.RouteId,
                    TotalSeats = x.TotalSeats

                }).Take(25).ToList() : []),
                Message = result.Message,
                Status = result.Status
            }
        };
        return View(response);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
