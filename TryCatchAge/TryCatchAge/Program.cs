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
                if (age < 0)
                {
                    throw new Exception("Age cannot be negative.");
                }
                Console.WriteLine($"Your age is: {age}");
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
