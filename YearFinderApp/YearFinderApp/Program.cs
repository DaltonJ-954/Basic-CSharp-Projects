using System;

namespace YearFinderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year was the first computer ever built?");
            int year = Convert.ToInt32(Console.ReadLine());
            bool firstOne = year == 1833;


            do
            {
                switch (year)
                {
                    case 1925:
                        Console.WriteLine("You chose the year 1925. It's an older year");
                        Console.WriteLine("Choose a year.");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1875:
                        Console.WriteLine("You chose the year 1875. It's an older year");
                        Console.WriteLine("Choose a year.");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1833:
                        Console.WriteLine("You chose the year 1833. That is the year Charles Babbage invented the first computer!");
                        firstOne = true;
                        break;
                    default:
                        Console.WriteLine("Your choices aren't yeilding results. You may need to do some research.");
                        Console.WriteLine("Choose a year.");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1954:
                        Console.WriteLine("1954 is obviously too modern of a year. Try a nore reasonable year");
                        Console.WriteLine("Guess a number.");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1901:
                        Console.WriteLine("You chose the year 1901. It's a much older year");
                        Console.WriteLine("Choose a year.");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1789:
                        Console.WriteLine("You chose the year 1789. You're too far back. Go higher.");
                        Console.WriteLine("Choose a year.");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!firstOne);
            Console.ReadLine();
        }
    }
}
