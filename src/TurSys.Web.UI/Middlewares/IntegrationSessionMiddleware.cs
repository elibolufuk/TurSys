using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TurSys.Application.Clients.Interfaces;
using TurSys.Web.UI.Constants;

namespace TurSys.Web.UI.Middlewares;

public class IntegrationSessionMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;

    public async Task InvokeAsync(HttpContext context, [FromServices] ISessionClient sessionClient)
    {
        if (context.User.Identity?.IsAuthenticated == false)
        {
            var session = await sessionClient.GetSession();
            if (session.Status == "Success")
            {
                var claims = new List<Claim>
                {
                    new(ClaimTypes.NameIdentifier, session.Data.SessionId),
                    new(ClaimTypesConstants.SessionId,session.Data.SessionId),
                    new(ClaimTypesConstants.DeviceId,session.Data.DeviceId),
                    new(nameof(session.Data.DeviceType),session.Data.DeviceType.ToString()),
                    new(nameof(session.Data.IpCountry),session.Data.IpCountry),
                    new(ClaimTypesConstants.Language,"tr-TR")
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, properties: new()
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddHours(24)
                });
            }
        }
        await _next(context);
    }
}