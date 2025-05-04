public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; }

    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public string UserId { get; set; }
    public IdentityUser User { get; set; }
}
