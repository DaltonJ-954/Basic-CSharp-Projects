using System;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int lambo = 200;
            Vehicle auto = new Vehicle();
            Car car = new Car();
            Tank tink = new Tank();

            Console.WriteLine("What is the top speed of the car?");
            car.speed = Convert.ToInt32(Console.ReadLine());

            if (car.speed >= 151 && car.speed < 250)
            {
                Console.WriteLine("The speed is super fast, and could surpass racing cars!");
            }
            else if (car.speed <= 150 && car.speed >= 81)
            {
                Console.WriteLine("This is fast and can get you alot of speeding tickets.");
            }
            else if (car.speed <= 80 && car.speed > 10)
            {
                Console.WriteLine("A standard speed that is suitable for the general public.");
            }
            else
            {
                Console.WriteLine("A vehicle should not be on thee road at this speed.");
                return;
            }
            tink.blast();
            auto.takeOff();
            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int speed = 80;
        public int year = 2021;
        public string model = "Mustang";

        public void takeOff()
        {
            Console.WriteLine("The vehicle is in motion!");
        }
    }
    class Car : Vehicle
    {
        public string make;
        public string model;
        public string engine;
        public int wheels;
    }
    class Tank
    {
        public int cannon;
        public double Weight;

        public void blast()
        {
            Console.WriteLine("Did you see how the tank destroyed those building to smithereens!");
        }
    }
}
