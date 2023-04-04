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
            MathOp mathOp1 = new MathOp();
            // Variable that are declared
            int theYear = 2022;
            decimal theMotor = 6.3m;
            string car = "4";

            Console.WriteLine(mathOp1.Mathmatical(theYear));
            Console.WriteLine(mathOp1.Mathmatical(theMotor));
            Console.WriteLine(mathOp1.Mathmatical(car));
        }

        

    }
}
