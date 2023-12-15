using System;

namespace Struct001
{
    public struct Number // A struct is of a value type that has characteristics of a class
    {
        decimal Amount { get; set; } // Property
    }

    class Program
    {
        static void Main(string[] args)
        {
            decimal Number = 43.50m; // Assigned a value to the struct Number and printed the result to the console.

            Console.WriteLine(Number);
        }
    }
}
