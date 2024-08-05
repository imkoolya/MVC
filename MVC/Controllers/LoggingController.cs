using Microsoft.AspNetCore.Mvc;

public class LoggingController : Controller
{
    private readonly ILoggingRepository _logging;

    public LoggingController(ILoggingRepository logging)
    {
        _logging = logging;
    }

    public async Task<IActionResult> Index()
    {
        var requests = await _logging.GetRequests();
        return View(requests);
    }
}