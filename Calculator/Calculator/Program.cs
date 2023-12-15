using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer;

            Console.WriteLine("Hello, welcome to the calculator program!");
            Console.WriteLine("Please enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter + for addition, - for subtraction, * for multiplicatio, or / for division.");

            answer = Console.ReadLine();

            if (answer == "+")
            {
                result = num1 + num2;
            }
            else if (answer == "-")
            {
                result = num1 - num2;
            }
            else if (answer == "*")
            {
                result = num1 * num2;
            }
            else if (answer == "%")
            {
                result = num1 % num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using the calculator program.");

            Console.ReadKey();
        }
    }
}
