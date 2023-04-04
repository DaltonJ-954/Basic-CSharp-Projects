using System;

namespace RandomInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            // A new variable created to pull from methods in the MathOperators class.
            MathOperators operation = new MathOperators();

            Console.WriteLine("Create a addtion operator.");
            int sum = Convert.ToInt32(Console.ReadLine()); // Convert integer into user input and returns a value lines 13, 17, and 19.
            Console.WriteLine(operation.Addition(sum));

            
            Console.WriteLine(operation.Subtraction(sum));

            Console.WriteLine(operation.Multiplication(sum));

            Console.ReadLine();
        }
    }
}
