using System;

namespace TryCatchAge
{
    class Program
    {
        static void Main()
        {
			while (true)
            {
                try
                {
                    Console.Write("Enter your birth year: ");
                    int birthYear = Convert.ToInt32(Console.ReadLine());

                    int currentYear = DateTime.Now.Year;
                    int age = currentYear - birthYear;

                    if (age < 0)
                    {
                        Console.WriteLine("You are not even born yet.");
                        int yearsUntilBirth = -age;
                        int actualYear = birthYear - currentYear;
                        Console.WriteLine($"Come back in {actualYear} years to when you may actually exist.");
                        break;
                    }
                    else if (age > 120)
                    {
                        Console.WriteLine($"You being {age} may be possible, but I believe it to be untrue.");
                        int yearsTooOld = DateTime.Now.Year - age;
                        Console.WriteLine($"You were born in the year {yearsTooOld}? How is this possible?");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You are {age} years old.");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
