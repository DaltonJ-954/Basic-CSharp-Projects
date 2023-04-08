using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq.Expressions;

namespace OperatorProps
{
    class Employee
    {
        // Three Properties in the Employee class.
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee employee, Employee employee2) // Constructor pulling two variables in it's parameter from the Property field.
        {
            if (employee.ID.Equals(employee2.ID)) // Comparing both ID values in the two instances to be true.
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Employee employee, Employee employee2) // Constructor pulling two variables in it's parameter from the Property field
        {
            if (!employee.ID.Equals(employee2.ID)) // Comparing both ID values in the two instances to not  be true.
            {
                return true;
            }
            return false;
        }

        //public bool Equals (Employee other)
        //{
        //    return other.ID.Equals(this.ID);
        //}

        ////public override bool Equals (object obj)
        ////{
        ////    Employee employee = obj as Employee;
        ////    if (employee != null)
        ////    {
        ////        return employee.ID.Equals(this.ID);
        ////    }
        ////    return false;
        ////}
    }
}
