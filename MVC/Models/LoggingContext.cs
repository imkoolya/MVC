using Microsoft.EntityFrameworkCore;

public sealed class LoggingContext : DbContext
{
    public DbSet<Request> Requests { get; set; }

    public LoggingContext(DbContextOptions<LoggingContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}