using System.Threading.Channels;
using System.Collections;
using System.Collections.Generic;

namespace DelegateTutorial2
{
    class Program
    {
        public delegate void StringDelegate(string text);

        static void Main(string[] args)
        {
            StringDelegate stringPosition = StringStart;

            WriteOutput("The first char is missing", stringPosition);

            stringPosition = StringEnd;

            // Call WriteOutput method with a message and the stringPosition delegate pointing to StringEnd
            WriteOutput("The last char is left", stringPosition);
        }

        // Method that takes a string and prints the string excluding the first character
        static void StringStart(string text) => Console.WriteLine(text.Substring(1));

        // Method that takes a string and prints the string starting from the 20th character that leaves only the last
        static void StringEnd(string text) => Console.WriteLine(text.Substring(20));

        // Method that prints a message and then calls the method referenced by the delegate
        static void WriteOutput(string text, StringDelegate stringPosition)
        {
            Console.WriteLine($"Before: {text}");

            // Call the method referenced by the delegate, passing the message as an argument
            stringPosition(text);
        }

    }
}
