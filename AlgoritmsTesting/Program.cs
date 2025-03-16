using System;
using System.Collections.Generic;

namespace AlgoritmsTesting
{
    public class Program
    {

        static void Main(string[] args)
        {
            string guidString = "12940678-abcd-1234-ef00-0123456789ab";
            Guid personalGuid = Guid.Parse(guidString);
            Console.WriteLine(guidString);

            Console.ReadKey();

            var greetings = new string[] { "hi", "hello", "hey", "howdy" };

            var results = greetings.Select(
                s => s[0].ToString().ToUpper() + s.Substring(1)
            );

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }
    }
}