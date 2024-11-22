using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraySelector
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your weight?");
            int yourWeight = Convert.ToInt32(Console.ReadLine());
            
            if (yourWeight >= 200)
            {
                Console.WriteLine("You are in the heavy-weight division.");
            }
            else if (yourWeight >= 170)
            {
                Console.WriteLine("You are in the middle-weight division.");
            }
            else if (yourWeight > 120 && yourWeight < 170)
            {
                Console.WriteLine("You're in 3 lower weight classes that are below the weight of 170.");
            }
            else
            {
                Console.WriteLine("You do not qualify to participate in this event.");
            }

            Console.WriteLine("Select an index with the desired string array to the screen");
            // String array method is a C# method that's similar to an array of strings
            string[] snakes = { "Rattlesnake", "Python", "Cobra", "GrassSnake", "Boa Constrictor", "Adder", "Anaconda", "Copper Head" };
            int snakeSelect = Convert.ToInt32(Console.ReadLine());

            // If statement  to search for arrays through choosing a particular index.
            if (snakeSelect > 7 || snakeSelect < 0)
            {
                Console.WriteLine("Out of range.");
            }
            else
            {
                Console.WriteLine(snakes[snakeSelect]);
            }
            Console.ReadLine();


            // Integer array method is a C# method that's similar to an array of integers.
            Console.WriteLine("Select an index with the desired string array to the screen");
            int[] numGroup = { 45, 100, 575, 3220, 3, 25, 15, 2023, 329 };
            int numSelect = Convert.ToInt32(Console.ReadLine());

            if (numSelect < 0 || numSelect > 9)
            {
                Console.WriteLine("Out of range.");
            }
            else
            {
                Console.WriteLine(numGroup[numSelect]);
            }
            Console.ReadLine();

            // List array method is a C# method that's similar to an array of a certain List<string>.
            Console.WriteLine("Grab an array  from a List<string> method in the index with a result on screen");
            List<string> programs = new List<string>();
            programs.Add("coding");
            programs.Add("tech");
            programs.Add("frameworks");
            programs.Add("JavaScript");
            int software = Convert.ToInt32(Console.ReadLine());

            if (software < 0 || software > 4)
            {
                Console.WriteLine("Out of range.");
            }
            else
            {
                Console.WriteLine(programs[software]);
            }
            Console.ReadLine();

            Stack<String> stack = new Stack<string>();

            stack.Push("Xbox Series X");
            stack.Push("Nintendo Switch");
            stack.Push("SNES");
            stack.Push("Xbox 360");
            stack.Push("DreamCast");

            Console.WriteLine(stack.Pop());

            Dictionary<String, String> States = new Dictionary<String, String>();

            States.Add("Florida", "Tallahassee");
            States.Add("Georgia", "Atlanta");
            States.Add("New York", "New York");
            States.Add("Hawaii", "Honolulu");
            States.Add("Arizona", "Phoenix");

            Console.WriteLine(States);
            Console.ReadKey();
        }
    }
}