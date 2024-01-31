using Microsoft.AspNetCore.Mvc;
using TurSys.Web.UI.Constants;

namespace TurSys.Web.UI.Controllers.BaseControllers;

[Route("[controller]")]
[ApiController]
public class BaseClientController<T>(ILogger<T> logger)
    : ControllerBase
    where T : class
{
    protected readonly ILogger<T> Logger = logger;
    protected string? DeviceId
        => User.Claims?
        .FirstOrDefault(x => x.Type == ClaimTypesConstants.DeviceId)?
        .Value;

    protected string? SessionId
        => User.Claims?
        .FirstOrDefault(x => x.Type == ClaimTypesConstants.SessionId)?
        .Value;

    protected string? Language
        => User.Claims?
        .FirstOrDefault(x => x.Type == ClaimTypesConstants.Language)?
        .Value;
}
