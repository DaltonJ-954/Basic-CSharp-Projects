using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethod
{
    public abstract class Person // An abstract class
    {
        public string firstName { get; set; } // Properties
        public string lastName { get; set; }

        public abstract void SayName() // Method
        {
            
        }
    }
}
