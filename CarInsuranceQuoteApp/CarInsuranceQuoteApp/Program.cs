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

            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("How many speeding tickets do you have?");
            int sum = Convert.ToInt32(Console.ReadLine());

            bool sampleBool = true;
            if (age > 15 && DUI && sum > 3 != sampleBool)
            {
                
            }

            Console.WriteLine("Qualified?");
            bool approved = Convert.ToBoolean(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
