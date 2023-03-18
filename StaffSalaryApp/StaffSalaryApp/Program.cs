using System;

namespace StaffSalaryApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            decimal HourlyRate = 24.75m;
            int HoursWorked = 40;
            decimal Person1 = HourlyRate * HoursWorked;
            Console.WriteLine("Annual salary of Person 1: " + Person1);

            Console.WriteLine("Person 2");
            decimal HourlyRate2 = 29.50m;
            int HoursWorked2 = 35;
            decimal Person2 = HourlyRate2 * HoursWorked2;
            Console.WriteLine("Annual salary of Person 2: " + Person2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");

            bool Per1OrPer2 = Person1 > Person2;
            Console.WriteLine(Per1OrPer2);
            Console.ReadLine();


        }
    }
}
