using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorProps
{
    class Employee
    {
        // Three Properties in the Employee class
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee (string FirstName, int ID) // Constructor pulling two variables in it's parameter from the Property field
        {
            this.FirstName = FirstName;
            this.ID = ID;
        }
        public Employee (int ID, string FirstName, string LastName) // Constructor that has all three variables in it's parameter
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
