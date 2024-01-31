namespace TurSys.Web.UI.Models.BaseModels;
public record BaseViewModel
{
#nullable disable
    public string Status { get; set; }
    public string Message { get; set; }
#nullable restore
}
