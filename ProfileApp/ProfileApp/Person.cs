using System;
using System.Collections.Generic;
using System.Text;

namespace ProfileApp
{
        public class Person
        {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //// Constructor
        //public Person(string first, string last)
        //{
        //    FirstName = first;
        //    LastName = last;
        //}
        public void SayName()
        {
            Console.WriteLine($"Name: " + FirstName + " " + LastName + ".");
        }
        }

            
}
