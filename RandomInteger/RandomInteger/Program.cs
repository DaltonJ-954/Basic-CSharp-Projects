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
            // Varible using all three methods of the class to perform mathmatical operations.
            operation.Addition = 23 + 7;
            Console.WriteLine(operation.Addition);

            Console.WriteLine("Create a subtraction operator.");
            operation.Subtraction = 46 - 13;
            Console.WriteLine(operation.Subtraction);

            Console.WriteLine("Create a multiplication operator.");
            operation.Multiplication = 33 * 419;
            Console.WriteLine(operation.Multiplication);

            Console.ReadLine();
        }
    }
}
