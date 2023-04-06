using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethod
{
    public class Employee : Person, IQuittable  // Employee class that inherits from the abstract Person class
    {
        public void SayName() // Method
        {
            return;
        }
    }
}
