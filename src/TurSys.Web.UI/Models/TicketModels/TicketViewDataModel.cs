using TurSys.Application.Responses;
using TurSys.Web.UI.Models.BaseModels;

namespace TurSys.Web.UI.Models.TicketModels;

public record TicketViewModel
{
#nullable disable
    public string Origin { get; set; }
    public string Destination { get; set; }
    public int OriginId { get; set; }
    public int DestinationId { get; set; }
    public DateTime Date { get; set; }
    public BaseViewDataModel<IList<TicketViewDataModel>> Response { get; set; }
#nullable restore
}
public record TicketViewDataModel
{
#nullable disable
    public string OriginLocation { get; set; }
    public string DestinationLocation { get; set; }
    public bool IsActive { get; set; }
    public JourneyResponse Journey { get; set; }
    public int Id { get; set; }
    public int PartnerId { get; set; }
    public string PartnerName { get; set; }
    public int RouteId { get; set; }
    public string BusType { get; set; }
    public string BusTypeName { get; set; }
    public int TotalSeats { get; set; }
    public int AvailableSeats { get; set; }
#nullable restore
}
