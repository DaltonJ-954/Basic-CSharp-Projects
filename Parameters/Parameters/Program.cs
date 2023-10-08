using System;
using System.Collections.Generic;
using System.Linq;

namespace Parameters
{
    public class Program
    {
        static void Main(string[] args)
        {

            unchecked
            {
                int a = int.MinValue;
                int b = 1;

                int result = a + b;
                Console.WriteLine(result);
            }

            int Addition(int x, int y)
            {
                return x + y;
            }

            List<string> fruits = new List<string> { "apple", "cherry", "grape", "plum" };
            Console.WriteLine(fruits[3]);
            Console.ReadLine();
        }
    }
}
