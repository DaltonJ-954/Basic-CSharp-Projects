using System;

namespace EnumsPar
{
    public enum DaysOfWeek
        {
            Monday=0,
            Tuesday=1,
            Wednesday=2,
            Thursday=3,
            Friday=4,
            Saturday=5,
            Sunday=6
        }
    class Program
    {
        static void Main(string[] args)
        {
            string day = "Tech";
            try
            {
                
                Console.WriteLine("Enter the current day of the week.");
                DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), day);
                if (today == DaysOfWeek.Monday)
                {
                    Console.WriteLine("It's Monday");
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    
}
