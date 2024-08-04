public class LoggingMiddleware
{
    private readonly RequestDelegate _next;

    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext context, ILoggingRepository _logging)
    {
        Console.WriteLine($"[{DateTime.Now}]: New request to http://{context.Request.Host.Value + context.Request.Path}");

        var newRequest = new Request
        {
            Url = $"http://{context.Request.Host.Value + context.Request.Path}"
        };

        await _logging.AddRequest(newRequest);

        await _next.Invoke(context);
    }
}