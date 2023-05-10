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

        Console.WriteLine("Enter task priority:");
        int priority;
        if (!int.TryParse(Console.ReadLine(), out priority))
        {
            Console.WriteLine("Invalid priority. Using default priority (0).");
            priority = 0;
        }

        TaskItem newTask = taskService.CreateTask(title, description, dueDate);

        Console.WriteLine($"Task created: {newTask.Title} (ID: {newTask.Id})");
    }

    private static string GetUserInput(string prompt)
{
    string input;
    do
    {
        Console.WriteLine(prompt);
        input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input cannot be empty. Please try again.");
        }
    } while (string.IsNullOrWhiteSpace(input));
    
    return input;
}
}

