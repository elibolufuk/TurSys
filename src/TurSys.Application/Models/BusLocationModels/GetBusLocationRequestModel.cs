using System.ComponentModel.DataAnnotations;

namespace TurSys.Application.Models.BusLocationModels;
public record GetBusLocationRequestModel
{
#nullable disable
    [Required(ErrorMessage = "Data gerekli.")]
    public string Data { get; set; }
#nullable restore
    [Required(ErrorMessage = "Date gerekli.")]
    public DateTime Date { get; set; }
}
