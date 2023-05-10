public class TaskService
{
    private List<TaskItem> _tasks = new List<TaskItem>();

    public void AddTask(TaskItem task)
    {
        _tasks.Add(task);
    }

    public void CompleteTask(int taskId)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == taskId);
        if (task != null)
        {
            task.IsComplete = true;
        }
    }

    public void MoveIncompleteTasks()
    {
        // Implementation for moving incomplete tasks to the end of the list.
    }
}