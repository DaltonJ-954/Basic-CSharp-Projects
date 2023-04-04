using System;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidEX @void = new VoidEX(); // Instantiation/constructor of the VoidEX class
            @void.mathOp(3, 8); // Math operation from the variable
            @void.mathOp(x : 8, y : 3);

            Console.ReadLine();
        }

    }
}
