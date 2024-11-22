using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace FilePath
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = @"C:\Users\scall\OneDrive\Documents\github.txt";
            // StreamReader is used to read characters to a stream in a specified encoding file.
            StreamReader reader = new StreamReader(path);

            string line = reader.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);

                line = reader.ReadLine();
            }

            string writeText = "My name is Dalton, and I am a graduate of The Tech Academy!";  // Create a text string
            File.WriteAllText(@"C:\Users\scall\OneDrive\Documents\GitHub\HTML-and-CSS-Projects\Dalton_Walls.txt", writeText);  // Create a file and write the content of writeText to it

            Console.WriteLine(writeText);
            Console.ReadKey();
            reader.Close();

            while (true)
            {
                Console.WriteLine("Enter your username please: ");
                string userName = Console.ReadLine();

                Console.WriteLine("Enter your password: ");
                double password = Convert.ToDouble(Console.ReadLine());

                if (userName == "Dalton Walls" && password == 721098)
                {
                    Console.WriteLine("Welco" + userName + "\n");
                    Console.WriteLine("\nUser password is: " + password + "\n");
                    Console.WriteLine("User is now logged in. Choose from options.");
                    break;
                }
                else if (userName != "Dalton Walls" && password == 721098)
                {
                    Console.WriteLine("You've entered an incorrect username. Try again.\n");
                }
                else if (userName == "Dalton Walls" && password != 721098)
                {
                    Console.WriteLine("You've entered an incorrect password. Please try again.\n");
                }
                else
                {
                    Console.WriteLine("You've entered the wrong username and password. Please try again.");
                }
            }
        }
    }
}