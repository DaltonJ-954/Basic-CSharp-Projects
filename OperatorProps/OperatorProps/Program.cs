using System;

namespace OperatorProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(33498, "Dalton", "Walls");
            Employee employee10 = new Employee(97204, "Tech", "Academy");

            if (employee.FirstName == employee10.FirstName)
            {
                Console.WriteLine("These two strings have the same value");
            }
            else
            {
                Console.WriteLine("These two strings are not of the same value");
            }
            Console.ReadLine();
        }
    }
}
