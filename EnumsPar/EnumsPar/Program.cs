using System;

namespace EnumsPar
{
    public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string day = Convert.ToString(Console.ReadLine());
                DaysOfWeek today = new DaysOfWeek();
                day = today.ToString();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
    
}
