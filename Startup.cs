using Microsoft.AspNetCore.Http;
using Objects;
using Objects.Services;

namespace Objects;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<TimeService>();

    }
    public void configure(IApplicationBuilder app, IWebHostEnvironment env, TimeService TimeSrv)
    {
        app.UseRouting();
        app.UseEndpoints(endpoints => 
        {
            endpoints.MapGet("/asd", async context => 
            {
            await context.Response.WriteAsync(TimeSrv.GetTime());
            });
        });
        app.UseMiddleware<ErrorMiddleware>();
        app.UseMiddleware<AuthMiddleware>();
        app.UseMiddleware<RoutingMiddleware>();
        

    }
}
