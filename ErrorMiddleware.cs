namespace Objects
{
    public class ErrorMiddleware
    {
        RequestDelegate _next;
        public ErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.ContentType = "text/plain; charset=utf-8";
            await  _next(context);
            if (context.Response.StatusCode == 403)
            {
                context.Response.WriteAsync("Доступ ограничен!");
                Console.WriteLine("Ошибка 403");
            }
            else if (context.Response.StatusCode == 404)
                context.Response.WriteAsync("Cтраница не найдена");


        }
    }
}
