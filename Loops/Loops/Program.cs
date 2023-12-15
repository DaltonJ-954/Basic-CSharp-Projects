using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool itsCorect = number == 62;


            do
            {
                switch (number)
                {
                    case 31:
                        Console.WriteLine("You guessed 31. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 62:
                        Console.WriteLine("You guessed the number 62. That is correct!");
                        itsCorect = true;
                        break;
                    case 110:
                        Console.WriteLine("You guessed 110. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!itsCorect);
            Console.ReadLine();
        }
    }
}
