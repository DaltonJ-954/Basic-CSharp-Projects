using System;
using System.Collections.Generic;

    class Program
    {
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //    Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Patrick", "Paul", "Kimberly", "Mika" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]);
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(77);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passinig test score: " + score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Stacy", "Aaron", "Kimb", "Mika" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}
        //Console.ReadLine();


        List<int> testScores = new List<int>() { 98, 67, 89, 81, 90, 94, 75, 81, 55, 99, 75, 12, 66 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
            if (score > 80)
            {
                passingScores.Add(score);
            }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();
    }
    }