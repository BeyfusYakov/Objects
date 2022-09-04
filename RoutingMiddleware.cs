using Microsoft.AspNetCore.Http;
using Objects;

namespace objects2 
{ 

public class RoutingMiddleware
{
    RequestDelegate _next;
    public RoutingMiddleware(RequestDelegate next)
    {
      _next = next;  
    }

    public async Task InvokeAsync(HttpContext context)
    {
        string path = context.Request.Path;
        if (path == "/" || path == "/index")
        {
            await context.Response.WriteAsync("<H2>Start or Index</H2>");
        }
        else
        {
            await context.Response.WriteAsync("<H2>Other Page</H2>");
        }
    }

} 

}