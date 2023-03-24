using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an index with the deisred string array to the screen");
            // String array method is a C# method that's similar to an array of strings
            string[] snakes = { "Rattlesnake", "Python", "Cobra", "GrassSnake", "Boa Constrictor", "Adder", "Anaconda" };
            int snakeSelect = Convert.ToInt32(Console.ReadLine());
            
            // If statement  to search for arrays through choosing a particular index.
            if (snakeSelect > 6 || snakeSelect < 0)
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
            int[] numGroup = { 45, 100, 575, 3220, 3, 25, 15, 2023 };
            int numSelect = Convert.ToInt32(Console.ReadLine());

            if (numSelect < 0 || numSelect > 8)
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
