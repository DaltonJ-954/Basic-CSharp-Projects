using System;
using System.Collections.Generic;

namespace ConstVar
{
    class Program
    {
        public class Car
        {
            private string make;
            private int year;

            public Car() : this("", 0) // This is a constructor
            {
            }

            public Car(string make, int year) // This is async second constructor
            {
                this.make = make;
                this.year = year;
            }
            static void Main(string[] args)
                {
                Car car1 = new Car(), car2 = new Car("G-Wagon", 2024); // These are two constructors instantiated and chained together.

                Console.WriteLine("I have a {0} that was made in the year {1}." ,car2.make, car2.year);
                Console.ReadLine();
                }
            }
        }
    }