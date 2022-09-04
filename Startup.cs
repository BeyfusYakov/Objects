using Microsoft.AspNetCore.Http;
//using Objects;
namespace Objects2;

public class Startup
{
    public void configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseRouting();
        app.UseEndpoints(endpoints => 
        {
            endpoints.MapGet("/asd", async context => 
            {
            await context.Response.WriteAsync("asd");
            });
        });

        app.UseMiddleware<RoutingMiddleware>();
    }
}
