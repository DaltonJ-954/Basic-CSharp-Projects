﻿using System;
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

        List<string> students = new List<string>()
        {
            "Becky", "Anne", "Robert", "Laura", "Chris", "Dianna", "Elane", "Tommy", "Suzanne"
        };

        List<int> testScores = new List<int>() { 200, 67, 81, 94, 75, 135, 55, 75, 12, 66, 120, 34, 101 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
            if (score < 100)
            {
                passingScores.Add(score);
            }
        Console.WriteLine(passingScores.Count);
        Console.WriteLine(students);
        Console.ReadLine();
    }
    }