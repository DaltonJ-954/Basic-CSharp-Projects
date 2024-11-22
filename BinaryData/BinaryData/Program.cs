using System;
using System.Linq;
using System.Collections.Generic;

namespace BinaryData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\scall\OneDrive\Documents\github.txt", r;
            string inputString = "Mary had a little lamb, her fleece was white as snow!";
            int[] indicesToReturn = { 0, 3, 6, 7, 10 };

            string[] words = inputString.Split(' ');

            Console.WriteLine(filePath);
            foreach (int index in indicesToReturn)
            {
                if (index >= 0 && index < words.Length)
                {
                    string word = words[index];
                    Console.WriteLine($"{index} {word}");
                }
                else
                {
                    Console.WriteLine($"Index {index} is out of range");
                }
            }

            int[,] numberMatrix =
            {
                { 1, 3, 5, 7, 9 },
                { 2, 4, 6, 8, 10 },
                { 5, 10, 15, 20, 25 }
            };
            Console.WriteLine(numberMatrix[1, 3]);


            try
            {
                Console.WriteLine("Enter a number: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a second number: ");
                double secondNum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(firstNum + secondNum);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
