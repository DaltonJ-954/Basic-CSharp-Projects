using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaEx
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Doe", Age = 67 },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", Age = 23 },
            new Employee { Id = 3, FirstName = "Bob", LastName = "Johnson", Age = 38 },
            new Employee { Id = 4, FirstName = "Samantha", LastName = "Lee", Age = 19 },
            new Employee { Id = 5, FirstName = "David", LastName = "Garcia", Age = 21 },
            new Employee { Id = 6, FirstName = "Emily", LastName = "Davis", Age = 54 },
            new Employee { Id = 7, FirstName = "Tom", LastName = "Wilson", Age = 88 },
            new Employee { Id = 8, FirstName = "Sarah", LastName = "Brown", Age = 30 },
            new Employee { Id = 9, FirstName = "Joe", LastName = "Taylor", Age = 27 },
            new Employee { Id = 10, FirstName = "Megan", LastName = "Clark", Age = 44 }
            };

            List<Employee> employeesStaff = new List<Employee>();
            // Print out the list of employees
            foreach (Employee employee in employeesStaff)
            {
                if (employee.Age > 22)
                {
                    Console.WriteLine(employee.Age);
                }
            }
            List<Employee> employees1 = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine(employees);
            Console.ReadLine();
        }
    }
}