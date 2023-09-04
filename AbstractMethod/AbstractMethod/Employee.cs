using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethod
{
    public class Employee : Person, IQuittable  // Employee class that inherits from the abstract Person class
    {
        public override void SayName() // Method
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " "  + this.rank + " " + this.gender + " " + this.age + "");

        }
    }
}
