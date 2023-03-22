using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 24 ? "You have an awesome favorite number!" : "You do not have an awesome favorite number.";

            Console.WriteLine(result);
            Console.ReadLine();

            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi,  " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmerm than the room temp.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not room temp.");
            //}
            //Console.ReadLine();

            //int currentTemperature = 70;
            //int roomTemperature = 63;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemperature >= roomTemperature)
            //{
            //    Console.WriteLine("It is exactly the room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("The room temp is very hot!");
            //}
            //else if (roomTemperature !> currentTemperature)
            //{
            //    Console.WriteLine("It may be a little chilly in the room.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not the exact room temperature.");
            //}
            Console.ReadLine();
        }
    }
}
