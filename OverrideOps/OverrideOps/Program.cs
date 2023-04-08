using System;

namespace OperatorProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Instantited.
            employee.ID = 1;
            employee.FirstName = "Dalton";
            employee.LastName = "Walls";

            Employee employee2 = new Employee(); // Second Instantiation.
            employee2.ID = 3;
            employee2.FirstName = "Dalton";
            employee2.LastName = "Walls";

            if (employee == employee2) // If/Else statement comparison of the two instances.
            {
                Console.WriteLine("The employee is equal to employee2.");
            }
            else
            {
                Console.WriteLine("The employee does not equal employee2");
            }
            Console.ReadKey();
        }
    }
}
