using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Parameters
{
    class Employee
    {
        public String Name { get; set; }
        public String Occupation { get; set; }
        public Double Hours { get; set; }
        public int ID { get; set; }
        public Double PayRate { get; set; }

        public Employee(int ID, String name, Double hours, String occupation, Double payrate)
        {
            this.ID = ID;
            this.Name = name;
            this.Hours = hours;
            this.Occupation = occupation;
            this.PayRate = payrate;
        }
    }
}