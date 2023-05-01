namespace PlanIt.Tests;
using PlanIt.Models;
using Xunit;

public class TaskManagerUnitTests
{
    [Fact]
    public void CreateTask_ShouldCreateNewTask()
    {
        // Arrange
        var taskManager = new TaskManager();
        string title = "Test task";
        string description = "Test task description";
        DateTime dueDate = DateTime.Today.AddDays(7);

        // Act
        var newTask = taskManager.CreateTask(title, description, dueDate);

        // Assert
        Assert.NotNull(newTask);
        Assert.Equal(title, newTask.Title);
        Assert.Equal(description, newTask.Description);
        Assert.Equal(dueDate, newTask.DueDate);
    }
}