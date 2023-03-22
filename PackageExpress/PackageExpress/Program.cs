using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What is your package weight?");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight > 50)
            {
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

            if (packWidth + packHeight + packLength > 50)
            {
                Console.WriteLine("Package too big to be shipped vie Package Express.");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Package weight qualifies for delivery, proceed.");
            }

            int dimensions = packLength * packHeight * packWidth;
            int stamped = dimensions * packWeight;
            int total = stamped / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + total + "\nThank You!");

            Console.ReadLine();
        }
    }
}
