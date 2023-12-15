using System;

namespace MethodEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Store mystore = new Store(); // Instantiate
            Console.WriteLine("Enter two numbers, though second number is optional.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            try // Attempts to run user provided numbers
            {
                int num2 = Convert.ToInt32(Console.ReadLine()); // Will cause format exception if blank.
                Console.WriteLine(mystore.clothes(num1, num2));
            }
            catch
            {
                Console.WriteLine(mystore.clothes(num1)); // If try fails, run catch method
            }
            Console.ReadLine();
        }
    }
}