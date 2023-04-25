using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime exact = DateTime.Now; // Instantiated DateTime method
            Console.WriteLine(exact);
            Console.ReadLine();

            Console.WriteLine("Enter a number."); // Prompt user input
            int currently = Convert.ToInt32(Console.ReadLine()); // Converts a string to integer
            Console.WriteLine(exact.AddHours(currently));
            Console.ReadLine();
        }
    }
}