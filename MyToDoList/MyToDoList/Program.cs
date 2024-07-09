using MyToDoList;
using System;

class Program
{
    static void Main(string[] args)
    {
        WhatToDo toDoList = new WhatToDo();

        while (true)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task as Completed");
            Console.WriteLine("4. Edit your Task");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter task title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter task description: ");
                        string description = Console.ReadLine();
                        Console.WriteLine("Date submitted: ");
                        DateTime date = DateTime.Now;
                        toDoList.AddTask(title, description);
                        break;
                    case 2:toDoList.ViewTasks();
                        break;
                    case 3:
                        Console.Write("Enter the task number to mark as completed: ");
                        if (int.TryParse(Console.ReadLine(), out int taskNumber))
                        {
                            toDoList.MarkTaskAsCompleted(taskNumber);
                        }
                        break;
                    case 4:
                        Console.Write("Enter the task number to edit: ");
                        if (int.TryParse(Console.ReadLine(), out int editTaskNumber))
                        {
                            Console.Write("Enter new task title: ");
                            string newTitle = Console.ReadLine();
                            Console.Write("Enter new task description: ");
                            string newDescription = Console.ReadLine();
                            toDoList.EditTask(editTaskNumber, newTitle, newDescription);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid choice.");
            }

        }
    }
}