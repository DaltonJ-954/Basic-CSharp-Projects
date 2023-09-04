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
            //This  calls the WriteLine() methods to display output to the console.
            Console.WriteLine("Many Miles Insurance Co. \n");
            Console.WriteLine("Get Insurance Quote Here! \n");

            Console.WriteLine("What is your age?");
            // The Convert method converts the "age" string to a integer.
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            // The Convert method converts the "DUI" string to a boolean.
            bool Yes = Convert.ToBoolean(Console.ReadLine());
            // Another string converted to integer.
            Console.WriteLine("How many speeding tickets do you have?");
            // Another string converted to integer.
            int sum = Convert.ToInt32(Console.ReadLine());

            
            if (age > 15 && !Yes && sum <=3)
            {
                Console.WriteLine("Qualified.");
            }
            else
            {
                Console.WriteLine("User is not qualified.");
            }

            Console.ReadLine();
        }
    }
}
