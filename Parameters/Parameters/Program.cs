using System;
using System.Collections.Generic;
using System.Linq;

namespace Parameters
{
    public class Program
    {
        static void Main(string[] args)
        {
            //double payRate = 24.75;
            //do
            //{
            //    Console.WriteLine(payRate);
            //    payRate += 0.75;
            //}
            //while (payRate < 33.00);
            // Auto-Implemented properties = a shortocut when there is no additional logic required in the property
            //                               you do not have to define a field for a property,
            //                               you only have to write get; and/or set; inside the property

            Employee employee = new Employee(00, "Joey Balbino", 40.59, "Engineer", 78.45);
            Employee employee2 = new Employee(01, "Char Les", 31.41, "Warehouseman", 25.60);
            Employee employee3 = new Employee(02, "Karl Smith", 24.23, "Engineer", 41.93);

            while(employee2.Hours <= 40.00)
            {
                Console.WriteLine(employee2.Hours + 9.00);
            }

            Console.WriteLine(employee2.Hours);

            Console.ReadKey();
        }
    }
}
