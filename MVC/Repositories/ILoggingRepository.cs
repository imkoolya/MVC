public interface ILoggingRepository
{
    Task AddRequest(Request request);
    Task<Request[]> GetRequests();
}