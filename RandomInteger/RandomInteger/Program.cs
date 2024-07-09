using System;

namespace RandomInteger
{
    public delegate void AdditionDelegate(int value);
    class Program
    {
        static void Main(string[] args)
        {
            AdditionDelegate additionDelegate = 

            // A new variable created to pull from methods in the MathOperators class.
            MathOperators operation = new MathOperators();

            Console.WriteLine("Create a addtion operator: ");
            int sum = Convert.ToInt32(Console.ReadLine()); // Convert integer into user input and returns a value lines 15, 17, 19.

            Console.WriteLine(operation.Addition(sum));
            
            Console.WriteLine(operation.Subtraction(sum));

            Console.WriteLine(operation.Multiplication(sum));

            Console.ReadKey();

            Console.WriteLine("Create a division operator: ");
            int sum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(operation.Division(sum2));

            Console.ReadLine();
        }
    }
}
