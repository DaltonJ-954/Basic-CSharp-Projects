using System;

namespace ProfileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Instantiation of the Employee class
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
