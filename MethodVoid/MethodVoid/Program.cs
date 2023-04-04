using System;

namespace MethodVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleVoid example = new ExampleVoid();
            Console.WriteLine("Please enter a number: ");
            int enter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
        }
    }
}
