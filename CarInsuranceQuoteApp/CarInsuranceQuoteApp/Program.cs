using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceQuoteApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Many Miles Insurance Co. \n");
            Console.WriteLine("Get Insurance Quote Here! \n");

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 15)
            {
                Console.WriteLine("You are of legal age.");
            }
            else
            {
                Console.WriteLine("You must be at least 15+ to qualify.");
            }

            Console.WriteLine("Have you ever had a DUI?");
            bool Yes = true;
            bool No = false;

            if (Yes != true)
                
            {
                Console.WriteLine("You cannot have any DUIs on recored.");
            }
            else
            {
                Console.WriteLine("You have qualified");
            }

            Console.WriteLine("How many speeding tickets do you have?");
            int sum = Convert.ToInt32(Console.ReadLine());

            if (sum <= 3)
            {
                Console.WriteLine("You've passed the ticket requirement.");
            }
            else
            {
                Console.WriteLine("You are over the limit of tickets to qualify.");
            }



            Console.ReadLine();
        }
    }
}
