namespace PlanIt.Models;

public class TaskService
{
    private List<TaskItem> _tasks = new List<TaskItem>();
    private int _nextId = 1;
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
        var IncompleteTasks = _tasks.Where(t => !t.IsComplete).ToList();
        foreach (var task in IncompleteTasks)
        {
            _tasks.Remove(task);
            task.Priority++; // Increase the priority of the task
            _tasks.Add(task); // Add the task back to the end of the list
        }
    }

 public TaskItem CreateTask(string title, string description, DateTime dueDate, int priority)
    {
        var newTask = new TaskItem
        {
            Id = _nextId++,
            Title = title,
            Description = description,
            DueDate = dueDate,
            IsComplete = false,
            Priority = priority
        };

        _tasks.Add(newTask);

        return newTask;
    }

}