using System;
using System.Collections.Generic;

namespace ConstVar
{
    class Program
    {
        public class Car
        {
            private string make;
            private string model;
            private int year;

            public Car() : this("", "", 0) // This is a constructor
            {
            }

            public Car(string make, string model, int year) // This is async second constructor
            {
                this.make = make;
                this.model = model;
                this.year = year;
            }
            static void Main(string[] args)
                {
                Car car1 = new Car(), car2 = new Car("GMC", "Terrain", 2020); // These are two constructors instantiated and chained together.

                Console.WriteLine("I have a {0} {1}, that was made in the year {2}." ,car2.make, car2.model, car2.year);
                Console.ReadLine();
                }
            }
        }
    }