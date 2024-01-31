using System.ComponentModel.DataAnnotations;

namespace TurSys.Web.UI.Models.TicketModels;

public record TicketPostModel
{
    [Required(ErrorMessage = "Departuredate gerekli.")]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public string Departuredate { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    [Required(ErrorMessage = "Destinationid gerekli.")]
    public int Destinationid { get; set; }

    [Required(ErrorMessage = "Originid gerekli.")]
    public int Originid { get; set; }
}