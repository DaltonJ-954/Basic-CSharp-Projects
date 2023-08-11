using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime exact = DateTime.Now; // Instantiated DateTime method
            Console.WriteLine("The date is?");
            Console.WriteLine(exact);
            
            Console.WriteLine("Enter a number to be added to the current date."); // Prompt user input
            int currently = Convert.ToInt32(Console.ReadLine()); // Converts a variable name to an integer
            Console.WriteLine(exact.AddHours(currently));
            Console.ReadLine();
        }
    }
}