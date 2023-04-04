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
            string car = "4";

            Console.WriteLine(Mathmatical(theYear));
            Console.WriteLine(Mathmatical(theMotor));
            Console.WriteLine(Mathmatical(car));
        }

        // Methods are generally the block of codes or statements in a program that gives the user the ability to reuse and preserve memory.
        public static int Mathmatical(int theNumber) // A method that is defined by an integer with an argument in the parentheses.
        {
            int result = theNumber * theNumber; // Integer the equals a math operation.
            return result; // The return function returns a value.
        }
        public static int Mathmatical(decimal theLength) //
        {
            int area = Convert.ToInt32(34 * theLength); // An integer has been converted into user input
            
            return area;
        }

        public static int Mathmatical(string car)
        {
            int word = Convert.ToInt32(car) + 9;
            return word;
        }

    }
}
