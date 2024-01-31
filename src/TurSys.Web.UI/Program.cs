using TurSys.Web.UI.Extension;
using TurSys.Application.Extensions;
using TurSys.Web.UI.Middlewares;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();

// Add services to the container.
if (builder.Environment.IsDevelopment())
    builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
else
    builder.Services.AddControllersWithViews();

#region My services(DI)

builder.Services.AddServiceCollections(builder.Configuration);
builder.Services.AddApplicationServiceCollections(builder.Configuration);

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();
app.UseMiddleware<IntegrationSessionMiddleware>();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
