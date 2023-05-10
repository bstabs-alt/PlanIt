public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DueDate { get; set; } = DateTime.MinValue;
    public bool IsComplete { get; set; }
    public int Priority {get; set;}
}