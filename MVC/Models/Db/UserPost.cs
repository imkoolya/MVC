public class UserPost
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}