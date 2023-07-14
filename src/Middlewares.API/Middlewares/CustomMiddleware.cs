namespace Middlewares.API.Middlewares;

public class CustomMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        await context.Response.WriteAsync("Hellow from Custom Middleware\n");
        await next(context);
    }
}
