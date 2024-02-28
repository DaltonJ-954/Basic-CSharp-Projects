using System;
using System.Collections.Generic;

namespace MyToDoList
{
    public class WhatToDo
    {
        private List<Task> tasks = new List<Task>();

        public void AddTask(string title, string description)
        {
            tasks.Add(new Task
            {
                Title = title,
                Description = description,
                IsCompleted = false
            });
        }

        public void ViewTasks()
        {
            Console.WriteLine("To-Do List:");
            int taskNumber = 1;
            foreach (var task in tasks)
            {
                Console.WriteLine($"{taskNumber}. Title: {task.Title}");
                Console.WriteLine($"   Description: {task.Description}");
                Console.WriteLine($"   Status: {(task.IsCompleted ? "Completed" : "Incomplete")}");
                Console.WriteLine();
                taskNumber++;
            }
        }

        public void MarkTaskAsCompleted(int taskNumber)
        {
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks[taskNumber - 1].IsCompleted = true;
            }
        }
    }
}
        
