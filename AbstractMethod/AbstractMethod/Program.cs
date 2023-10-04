using System;

namespace AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Instantiated from the Employee class
            employee.firstName = "Jessica"; // employee object that calls on the properties of the Person class
            employee.lastName = "Simpson";
            employee.rank = "Elite";
            employee.gender = "Female";
            employee.age = 35;
            employee.SayName();
            Console.WriteLine("Good afternoon, " + employee.firstName + " " + employee.lastName + ". I see that you're a " + employee.gender + ", and you're " + employee.rank + " rank is prestigious.");

            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadKey();
        }
    }
}
