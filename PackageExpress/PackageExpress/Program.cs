using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // The WriteLine() writes the specified data, followed by the current line terminator, to the standard output stream.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What is your package weight?");
            // Covert.ToInt32 turns a string in to an integer.
            int packWeight = Convert.ToInt32(Console.ReadLine());
            // If statement returning back data that determines if weight is heavier or lighter than 50 lbs.
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                // Terminates this process and returns an exit code to the operating system.
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Package weight qualifies for delivery, proceed.");
            }

            Console.WriteLine("What is your package width?");
            int packWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your package height?");
            int packHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your package length?");
            int packLength = Convert.ToInt32(Console.ReadLine());
            // Adding variables total 
            if (packWidth + packHeight + packLength > 50)
            {
                Console.WriteLine("Package too big to be shipped vie Package Express.");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Package weight qualifies for delivery, proceed.");
            }
            Console.ReadLine();
            // Variable using multiplication and divide operators.
            int dimensions = packLength * packHeight * packWidth;
            int stamped = dimensions * packWeight;
            int total = stamped / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + total + "\nThank You!");

            Console.ReadLine();
        }
    }
}
