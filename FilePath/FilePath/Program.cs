using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FilePath
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = @"C:\Users\scall\OneDrive\Documents\github.txt";
            // StreamReader is used to read characters to a stream in a specified encoding file.
            StreamReader reader = new StreamReader(path);

            // The ternary operator(?) consist of 3 operands. It is often used as a convenience (syntatic sugar) to replace simple if else statements
            string? line = reader.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);

                line = reader.ReadLine();
            }

            string writeText = "I am Dalton Walls, and I love coding!";  // Create a text string
            File.WriteAllText(@"C:\Users\scall\OneDrive\Documents\GitHub\HTML-and-CSS-Projects\Dalton_Walls.txt", writeText);  // Create a file and write the content of writeText to it

            Console.ReadKey();
            reader.Close();
        }
    }
}
