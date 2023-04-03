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
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(operation.Addition(sum));

            
            Console.WriteLine(operation.Subtraction(sum));

            Console.WriteLine(operation.Multiplication(sum));

            Console.ReadLine();
        }
    }
}
