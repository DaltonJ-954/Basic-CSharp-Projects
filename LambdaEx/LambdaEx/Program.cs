using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace LambdaEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Doe" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
            new Employee { Id = 3, FirstName = "Bob", LastName = "Johnson" },
            new Employee { Id = 4, FirstName = "Samantha", LastName = "Lee" },
            new Employee { Id = 5, FirstName = "David", LastName = "Garcia" },
            new Employee { Id = 6, FirstName = "Emily", LastName = "Davis" },
            new Employee { Id = 7, FirstName = "Tom", LastName = "Wilson" },
            new Employee { Id = 8, FirstName = "Sarah", LastName = "Brown" },
            new Employee { Id = 9, FirstName = "Joe", LastName = "Taylor" },
            new Employee { Id = 10, FirstName = "Megan", LastName = "Clark" }
            };

            List<Employee> employeesStaff = new List<Employee>();
            // Print out the list of employees
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employeesStaff.Add(employee);
                }
            }
            List<Employee> employees1 = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine(employees);

            List<Employee> employees2 = employees.Where(n => n.Id > 5).ToList();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}