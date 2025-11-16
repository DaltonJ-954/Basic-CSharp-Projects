using System;
using System.Collections.Generic;
using System.Linq;

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

            var cities = new string[] { "Toronto", "Miami", "Houston", "Salt Lake", "Chicago", "Detroit", "Baltimore" };

            var results = cities.Select(
                s => s[0].ToString().ToLower() + s.Substring(1)
            );

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("Enter a Key");
            int var1 = Console.Read();
            Console.WriteLine($"ASCII Value of the Entered Key is: {var1}");
        }
    }
}