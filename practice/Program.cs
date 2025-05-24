//using System; //It's a core namespace in .NET that contains fundamental classes like 
// Console (for input/output), String, Math, and many others.
//using System.Linq; // LINQ is a powerful set of methods for querying and manipulating 
// collections (arrays, lists, etc.) in a very readable and expressive way.
// 1- Problem Statement:
//Write an algorithm to find the largest number in a given array of integers.
/*
double[] doublesVars = {2.4, 5, 6.6, 3, 5};
double largestNum = doublesVars[0];
foreach (double num in doublesVars)
{
    if (num > largestNum)
    {
        largestNum = num;
    }
}
Console.WriteLine(largestNum);
*/
// Problem Statement:
//Write an algorithm to check if a given number is even or odd.
/*
int num = 41;
if (num % 2 == 0)
{
    Console.WriteLine($"The number {num} is even.");
}
else
{
    Console.WriteLine($"The number {num} is odd.");
}
*/
/*
//3-  Problem Statement:
// Write an algorithm that calculates the sum of all numbers in a given array of integers.
double[] arrayDouble = { 1.5, 2, 3 };
double sum = 0;
foreach (double num in arrayDouble) {
    sum += num;
}
Console.WriteLine(sum);
*/
//4- Problem Statement:
// Write an algorithm to count the number of vowels (a, e, i, o, u) in a given string.
/*
int vowelCount = 0;
char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
string varString = "I want to be happy in life by doing what I like";
foreach (char character in varString.ToLower())
{
    if (vowels.Contains(character)){
        vowelCount += 1;

    }
}
*/
/*
public class Program
{
    // Function to calculate the area of a triangle
    static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
    public static void Main()
    {
        // Prompt the user to input the base length
        Console.WriteLine("Enter the base length of the triangle:");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        // Prompt the user to input the height
        Console.WriteLine("Enter the height of the triangle:");
        double height = Convert.ToDouble(Console.ReadLine());
        // Call the function to calculate the area
        double area = CalculateTriangleArea(baseLength, height);
        // Output the result
        Console.WriteLine("The area of the triangle is: " + area);
    }
}
*/
/*
using System;
public class Program {
	public static void Main() {


Console.WriteLine("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = AddNumbers(num1, num2);

Console.WriteLine("The sum of the numbers is: " + result);

}
	static int AddNumbers(int a, int b) {
		return a + b;
	}
}
*/
// Defining and Calling a Simple Method****************************************
/*
using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // Method definition
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to our Program!");
        }
        // Call the Method
        DisplayWelcomeMessage();
    }
}
*/
// Creating a Method with Parameters ******************************************
/*
using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // Method Definition
        static void GreetUser(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }
        // Call the method
        GreetUser("Amr");
    }

}
*/
// Using Methods with Return Values***********************************************
/*
using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // Method Definition
        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }
        // Call the Method
        int sum = CalculateSum(2, 4);
        Console.WriteLine("The sum is: " + sum);
    }
}
*/
// Combining Methods and Conditional Logic ********************
/*
using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // Call the method
        int num = 3;
        bool result = IsPositive(num);
        if (result)
        {
            Console.WriteLine("The number is Positive.");
        }
        else
        {
            Console.WriteLine("The number is negative");
        }
        IsPositive(4);
        // Define a method 
        static bool IsPositive(int number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
*/
// Practical Application – User Age Validation *************************************
/*
using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // Call Mehod
        int age = 0;
        do
        {
            Console.WriteLine("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Age must be greater than 0.");
                }

            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a valid integer.");
            }

        } while (true);

        bool canDrive = IsOldEnoughToDrive(age);
        if (canDrive)
        {
            Console.WriteLine("You are old enough to Drive.");
        }
        else
        {
            Console.WriteLine("You are not old enough to drive.");
        }
    }
    // Method Definition
    static bool IsOldEnoughToDrive(int age)
    {
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}
*/
// Practical Application of Coding Concepts
/*
using System;
using System.Linq;
using System.Runtime.InteropServices;
public class Program
{
    public static string task1 = "";
    public static string task2 = "";
    public static string task3 = "";

    public static bool task1Completed = false;
    public static bool task2Completed = false;
    public static bool task3Completed = false;

    public static void Main(string[] args)
    {
        // Create a loop that runs untill user quit
        Console.WriteLine("Choose option - (1)=Add Task, (2)=Mark Complete, (3)=Display Tasks, (4)=Quit: ");
        string option = Console.ReadLine();
        while (option != "4")
        {
            if (option == "1")
            {
                EnterTask();
            }
            else if (option == "2")
            {
                MarkCompleted();
            }
            else if (option == "3")
            {
                DisplayTasks();
            }

            if (option != "4")
            {
			Console.WriteLine("Choose option - (1)=Add Task, (2)=Mark Complete, (3)=Display Tasks, (4)=Quit: ");
			option = Console.ReadLine();
            }
        }
    }

    public static void EnterTask() {
        Console.WriteLine("Add your task: ");
        string newTask = Console.ReadLine();
        if (string.IsNullOrEmpty(task1))
        {
            task1 = newTask;
        }
        else if (string.IsNullOrEmpty(task2))
        {
            task2 = newTask;
        }
        else if (string.IsNullOrEmpty(task3))
        {
            task3 = newTask;
        }
        else
        {
            Console.WriteLine("Your task list is full.");
        }
    }

    public static void MarkCompleted() {
        Console.WriteLine("Which task would you like to mark as completed (1, 2, or 3)?");
        int taskToComplete = int.Parse(Console.ReadLine());
        if (taskToComplete == 1 && !string.IsNullOrEmpty(task1))
        {
            task1Completed = true;
            Console.WriteLine("Task 1 marked as completed.");
        }
        else if (taskToComplete == 2 && !string.IsNullOrEmpty(task2))
        {
            task2Completed = true;
            Console.WriteLine("Task 2 marked as completed.");
        }
        else if (taskToComplete == 3 && !string.IsNullOrEmpty(task3))
        {
            task3Completed = true;
            Console.WriteLine("Task 3 marked as completed.");
        }
        else
        {
            Console.WriteLine("Invalid task selection.");
        }
    }
    public static void DisplayTasks() {
        Console.WriteLine("Your Tasks:");
        if (!string.IsNullOrEmpty(task1)) 
        {
            Console.WriteLine(task1Completed ? "Task 1: " + task1 + " [Completed]" : "Task 1: " + task1 + " [Pending]");
        }
        if (!string.IsNullOrEmpty(task2)) 
        {
            Console.WriteLine(task2Completed ? "Task 2: " + task2 + " [Completed]" : "Task 2: " + task2 + " [Pending]");
        }
        if (!string.IsNullOrEmpty(task3)) 
        {
            Console.WriteLine(task3Completed ? "Task 3: " + task3 + " [Completed]" : "Task 3: " + task3 + " [Pending]");
        }
    }

}
*/
/*

using System;
using System.Collections.Generic;

class TaskManager
{
    static List<string> tasks = new List<string>();
    static List<bool> taskStatus = new List<bool>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Task Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Completed");
            Console.WriteLine("3. View Tasks");
            Console.WriteLine("4. Exit");
            Console.WriteLine("What would you like to do? (choose 1-4)");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    CompleteTask();
                    break;
                case "3":
                    ViewTasks();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Enter task description:");
        string? task = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(task))
        {
            Console.WriteLine("Task description cannot be empty.");
            return;
        }
        tasks.Add(task);
        taskStatus.Add(false);  // Marking as not completed by default
        Console.WriteLine("Task added successfully.");
    }

    static void CompleteTask()
    {
        if (tasks.Count == 0)
        {
            Console.Write("No tasks available to complete.");
            return;
        }
        Console.WriteLine("Enter task number to mark as completed:");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && (taskNumber > 0 && taskNumber <= tasks.Count))
        {
            taskStatus[taskNumber - 1] = true;
            Console.WriteLine($"Task '{tasks[taskNumber-1]}' marked as completed.");

        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
        
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No Tasks avavilable.");
            return;
        }
        Console.WriteLine("Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            string status = taskStatus[i] ? "Completed" : "Pending";
            Console.WriteLine($"{i + 1}. {tasks[i]} - {status}");
        }
    }
}
*/
/*
// Simple program to use Pastal
using System.Drawing;
using Pastel;

public class Program
{
    public static async Task Main(string[] args)
    {
        // Calling async SimulateDelay Method
        SimulateDelay();
        // Printing timer for 5 seconds
        Console.WriteLine("Timer started for 5 seconds...");
        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine(i);
            await Task.Delay(1000); // Wait for 1 second
        }
    }
    public static async Task SimulateDelay()
    {
        // Simulating a delay of 2 seconds
        await Task.Delay(5000);
        // Printing a message in green color using Pastel
        Console.WriteLine("Hello World!".Pastel(Color.Green));
    }
    
}
*/
/*
using System;
public class Program
{
    // DownloadDataAsunc Mehtod
    public static async Task DownloadDataAsync()
    {
        try
        {
            // Simulate a delay to mimic data download
            Console.WriteLine("Downloading data...");
            // Simulate error for demonstration
            throw new Exception("Simulated error during data download.");
            await Task.Delay(2000);
            Console.WriteLine("Data downloaded successfully.");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }


    }
    // DownloadDataAsunc2 Method
    public static async Task DownloadDataAsync2()
    {
        // Simulate a delay to mimic data download
        Console.WriteLine("Downloading data from second source.....");
        await Task.Delay(5000);
        Console.WriteLine("Data downloaded successfully from second source.");
    }

    public static async Task Main(string[] args)
    {
        // Call the DownloadDataAsync methods from both sources
        Task DownloadTask1 = DownloadDataAsync();
        Task DownloadTask2 = DownloadDataAsync2();
        // Wait for both tasks to complete
        await Task.WhenAll(DownloadTask1, DownloadTask2);
        // Print a message indicating completion
        Console.WriteLine("Tasks completed!.");
    }
}
*/
// Another Async and await example

using System;

public class Program
{
    public static async Task PerformLongOperationAsync()
    {
        Console.WriteLine("\nOperation started....");
        await Task.Delay(3000); // Simulate a long operation (3 seconds)
        Console.WriteLine("Operation completed successfully!");
    }
        public static async Task PerformLongOperationAsync2()
    {
        try
        {
            Console.WriteLine("\nOperation 2 started....");
            await Task.Delay(5000); // Simulate a long operation (3 seconds)
            // Throw new Exception("Simulated error in operation 2."); // Simulate an error
            //throw new Exception("Simulated error in operation 2.");
            Console.WriteLine("Operation 2 completed successfully!");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

    }
    public static void Main(string[] args)
    {
        Task.Run(async () =>
        {
            await Task.WhenAll(
                PerformLongOperationAsync(),
                PerformLongOperationAsync2()
            );
        }).Wait();
        Console.WriteLine("Main method completed.\n");
    }
}























