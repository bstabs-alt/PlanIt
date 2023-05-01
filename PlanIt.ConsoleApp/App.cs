using System;
using PlanIt.Models;

internal class App
{
    public static void Main(string[] args)
    {
        TaskService taskService = new TaskService();

        string title = GetUserInput("Enter task title:");
        string description = GetUserInput("Enter task description:");

        Console.WriteLine("Enter task due date (yyyy-mm-dd):");
        DateTime dueDate;
        if (!DateTime.TryParse(Console.ReadLine(), out dueDate))
        {
            Console.WriteLine("Invalid date format. Using today's date as default.");
            dueDate = DateTime.Now;
        }

        TaskItem newTask = taskService.CreateTask(title, description, dueDate);

        Console.WriteLine($"Task created: {newTask.Title} (ID: {newTask.Id})");
    }

    private static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine() ?? string.Empty;
    }
}