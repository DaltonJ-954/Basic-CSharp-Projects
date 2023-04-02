using System;

namespace MethodExample
{
    // A Class is like an object constructor, or a "blueprint" for creating objects.
    class Program
    {
        // The Main() method is an entry point of console and windows applications on the .NET or .NET Core platform. It is also an entry of ASP.NET Core web applications.
        public static void Main(string[] args)
        {
            // This is an instantiation of a class.
            Example example = new Example();
            // Console.WriteLine  is used to print data along with printing the new line.
            Console.WriteLine("Enter a number: ");
            // Convert class provides different methods to convert a base data type to another base data type. 
            example.Boys = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            example.Girls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(example.Girls + example.Boys);
            // This method is used to read the next line of characters from the standard input stream.
            Console.ReadLine();
        }
    }
}
