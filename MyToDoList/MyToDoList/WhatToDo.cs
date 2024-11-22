using System;
using System.Collections.Generic;

namespace MyToDoList
{
    public class WhatToDo
    {
        private readonly List<Task> tasks = new List<Task>();
        public void AddTask(string title, string description)
        {
            tasks.Add(new Task
            {
                Title = title,
                Description = description,
                IsCompleted = false
            });
        }

        public void EditTask(int index, string newTitle, string editDescription)
        {
            if (index >= 1 && index < tasks.Count + 1)
            {
                tasks[index].Title = newTitle;
                tasks[index].Description = editDescription;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }
        }

        public void ViewTasks()
        {
            Console.WriteLine("To-Do List:");
            int taskNumber = 1;
            foreach (var task in tasks)
            {
                Console.WriteLine($"{taskNumber}. Title: { task.Title }");
                Console.WriteLine($"   Description: { task.Description }");
                Console.WriteLine($"   Status: { (task.IsCompleted ? "Completed" : "Incomplete") }");
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Console.WriteLine(timestamp);
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