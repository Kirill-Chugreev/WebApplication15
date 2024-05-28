namespace WebApplication15
{
    public class RoutingMiddleware
    {
        public RoutingMiddleware(RequestDelegate _)
        {
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path;
            if (path == "/admin")
            {
                await context.Response.WriteAsync("Admin Page");
            }
            else if (path == "/user")
            {
                await context.Response.WriteAsync("User Page");
            }
            else
            {
                context.Response.StatusCode = 404;
            }
        }
    }
}
