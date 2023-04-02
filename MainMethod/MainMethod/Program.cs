using System;

namespace MainMethod
{
    // Classes are declared using the keyword class, as shown in the following example:
    class Program
    {
        // Void is a keyword, it is a reference type of data type and used to specify the return type of a method in C#
        // Public, in C#, is a keyword used to declare the accessibility of a type and type member such that the access is not limited.
        // Static is a modifier in C# which is applicable to classes, variables, methods, and constructors.
        public static void Main(string[] args)
        {
            // Variable that are declared
            int theYear = 2022;
            decimal theMotor = 6.3m;
            string car = "Camero";

            Mathmatical (theYear, theMotor, car);
        }

        // Methods are generally the block of codes or statements in a program that gives the user the ability to reuse and preserve memory.
        public static void Mathmatical(int theNumber)
        {
            int result = theNumber * theNumber;
            Console.WriteLine("The square of " + theNumber + " is: " + result);
            Console.ReadLine();
        }
        public static void Mathmatical(decimal theLength, int theWidth)
        {
            decimal area = theWidth * theLength;
            Console.WriteLine("The area is: " + area);
            Console.ReadLine();
        }
        public static void Mathmatical (int theYear, decimal theMotor, string car)
        {
            Console.WriteLine("I purchased a " + theYear + ", " + car + " " + theMotor + " automobile.");
            Console.ReadLine();
        }

    }
}
