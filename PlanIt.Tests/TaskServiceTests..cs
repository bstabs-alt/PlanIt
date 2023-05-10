namespace PlanIt.Tests;
using PlanIt.Models;
using Xunit;

public class TaskServiceTests
{
    [Fact]
    public void CreateTask_ShouldCreateNewTask()
    {
        // Arrange
        var taskManager = new TaskService();
        string title = "Test task";
        string description = "Test task description";
        DateTime dueDate = DateTime.Today.AddDays(7);
        int priority = 0;

        // Act
        var newTask = taskManager.CreateTask(title, description, dueDate, priority);

        // Assert
        Assert.NotNull(newTask);
        Assert.Equal(title, newTask.Title);
        Assert.Equal(description, newTask.Description);
        Assert.Equal(dueDate, newTask.DueDate);
        Assert.Equal(priority, newTask.Priority);
    }
}
