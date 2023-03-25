using System;
using System.Collections.Generic;

    class Program
    {
    static void Main(string[] args)
    {
        // A string is an object of type String whose value is text variable. This variable is assigning an array of different types of animals.
        string[] animals = { "horses", "turtles", "dogs", "birds", "bears" };
        // Writes the specified data, followed by the current line terminator, to the standard output stream
        Console.WriteLine("What is your favorite type of animal?");
        // The foreach statement executes a statement or a block of statements for each element in an instance of the type
        foreach (string type in animals)
            // In C#, if statement is used to indicate which statement will execute according to the value of the given boolean expression
            if (type == "horses")
            {
                Console.WriteLine("My favorite kind of animal are " + type);
            }
        // The for statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. 
        for (int a = 0; a < animals.Length; a++)
            {
             Console.WriteLine(animals[a]);
            }

        Console.ReadLine();
        // Reads the next line of characters from the standard input stream
        Console.ReadLine();
    }
    }
