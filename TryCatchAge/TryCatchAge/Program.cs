using System;

namespace TryCatchAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");
            string year = Console.ReadLine();
            int age;

            try
            {
                age = Convert.ToInt32(year);
                if (age < 1)
                {
                    throw new Exception("You are not even born yet.");
                }
                Console.WriteLine($"Your age is: {age}");
                if (age > 120)
                {
                    throw new Exception($"You will not live to be {year} years old.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
