using System;

namespace AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Instantiated from the Employee class
            employee.firstName = "Sample"; // employee object that calls on the properties of the Person class
            employee.lastName = "Student";
            employee.SayName();
            Console.WriteLine("" + employee.firstName + " " + employee.lastName + "");
        }
    }
}
