using Microsoft.AspNetCore.Http;

namespace Objects
{
    public class AuthMiddleware
    {
        RequestDelegate _next;
        public AuthMiddleware(RequestDelegate next)
        {
            _next = next; 
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string token = context.Request.Query["token"];
            if (string.IsNullOrEmpty(token))
            {
                context.Response.StatusCode = 403;
                Console.WriteLine("Доступ запрещен");
            }
            else
            {
               /* await */ _next(context);
            }
        }
    }
}
