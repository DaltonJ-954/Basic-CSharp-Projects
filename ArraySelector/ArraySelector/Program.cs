using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So let's see what we can do to help you with you weight problems.");
            List<double> weight = new List<double>();
            weight.Add(121.54);
            weight.Add(265.11);
            weight.Add(206);
            weight.Add(45.34);
            weight.Add(175.18);
            weight.Add(15.23);

            int weightIssues = Convert.ToInt32(Console.ReadLine());
            if (weightIssues < 10 || weightIssues > 270)
            {
                Console.WriteLine("You need to get yourself in shape, now!");
            }
            else
            {
            Console.WriteLine(weight[weightIssues]);
            }

        Console.WriteLine("Select an index with the deisred string array to the screen");
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
            Console.WriteLine("Select an index with the deisred string array to the screen");
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
        }
    }
