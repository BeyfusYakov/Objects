using Microsoft.AspNetCore.Http;
using Objects;

namespace Objects
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
        string path = context.Request.Path.Value.ToLower();
            if (path == "/" || path == "/index")
            {
                await context.Response.WriteAsync("<H2>Start or Index</H2>");
                Console.WriteLine("Зашли на стартовую страницу");
            }
            else if (path == "/home")
            {
                await context.Response.WriteAsync("<H2>Other Page</H2>");
            }
            else
            { context.Response.StatusCode = 404;
                Console.WriteLine("Неизвестная страница");
            }
    }

} 

}