public class Article
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Preview { get; set; }
    public string? Content { get; set; }
    public DateOnly PublishDate { get; set; }
    public List<Comment>? Comments { get; set; }
}