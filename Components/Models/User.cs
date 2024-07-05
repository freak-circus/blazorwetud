public class User
{
    public int Id { get; set; }
    public string? Username { get; set; }
    public string? PasswordHash { get; set; }
    public string? Email { get; set; }
    public List<Task>? CompletedTasks { get; set; }
    public List<QuizTask>? CompletedQuizTasks { get; set;}
}