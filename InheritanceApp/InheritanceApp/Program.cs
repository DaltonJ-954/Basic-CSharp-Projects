using System;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat();
            Car car = new Car();

            Console.WriteLine(boat.Motor);
            Console.WriteLine(car.Speed);
            boat.takeOff();

            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int Speed = 60;
        public int Year = 2021;
        public string model = "Mustang";

        public void takeOff()
        {
            Console.WriteLine("The vehicle is in motion!");
        }
    }
    class Car : Vehicle
    {
        public string model;
        public string Engine;
        public int Wheels;
    }
    class Boat : Vehicle
    {
        public string Length = "35 feet";
        public string Motor = "Subber Whammy";
        public int Wheels = 1;
    }
    class DirtBike : Vehicle
    {
        public int Wheels;
    }
}
