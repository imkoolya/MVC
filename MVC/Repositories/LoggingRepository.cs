using Microsoft.EntityFrameworkCore;

public class LoggingRepository : ILoggingRepository
{
    private readonly LoggingContext _context;

    public LoggingRepository(LoggingContext context)
    {
        _context = context;
    }

    public async Task AddRequest(Request request)
    {
        request.Id = Guid.NewGuid();
        request.Date = DateTime.Now;

        var entry = _context.Entry(request);
        if (entry.State == EntityState.Detached)
            await _context.Requests.AddAsync(request);

        await _context.SaveChangesAsync();
    }
}