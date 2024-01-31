namespace TurSys.Web.UI.Models.BaseModels;

public record BaseViewDataModel<T> : BaseViewModel
{
    public T? Data { get; set; }
}
