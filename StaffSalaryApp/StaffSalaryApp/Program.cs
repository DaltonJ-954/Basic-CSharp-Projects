using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffSalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            decimal HourlyRate = Convert.ToDecimal(Console.ReadLine());
            int HoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            decimal HourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            int HoursWorked2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1: ");
            decimal one = HourlyRate * HoursWorked * 52;
            Console.WriteLine(one);

            Console.WriteLine("Annual salary of Person 2: ");
            decimal two = HourlyRate2 * HoursWorked2 * 52;
            Console.WriteLine(two);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(one > two);

            Console.ReadKey();
        }
    }
}
