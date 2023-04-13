using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime exact = new DateTime(); // Instantiated DateTime method
            Console.WriteLine("Enter a number."); // Prompt user input
            int currently = Convert.ToInt32(Console.ReadLine()); // Converts a string to integer
            currently += exact.Hour; // The variable "currently" outputs a value that the DateTime function can return total hours.
            Console.WriteLine(currently);
        }
    }
}
