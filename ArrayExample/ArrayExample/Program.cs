using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
    static void Main(String[] args)
    {
        // A string is an object of type String whose value is text variable. This variable is assigning an array of different types of animals.
        string[] animals = { "horses", "turtles", "dogs", "birds", "bears" };
        // Writes the specified data, followed by the current line terminator, to the standard output stream
        Console.WriteLine("What is your favorite type of animal?: " + animals);
        // The foreach statement executes a statement or a block of statements for each element in an instance of the type
        foreach (string type in animals)
            // In C#, if statement is used to indicate which statement will execute according to the value of the given boolean expression
            if (type == "dogs")
            {
                Console.WriteLine("My favorite type of animal are " + type);
            }
        // The for statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. 
        for (int a = 0; a < animals.Length; a++)
        {
            Console.WriteLine(animals[a]);
        }
        // This is a loop that results in a loop using the leass than(<) sign.
        while (animals.Length < 6)
        {
            Console.WriteLine("To infininty and beyond!");
            break;
        }
        // This is a loop that results in a loop using the leass than and equal(<=) sign.
        while (animals.Length <= 6)
        {
            Console.WriteLine("Is it safe not to loop infinitely anymore?");
            break;
        }
        // Reads the next line of characters from the standard input stream.
        Console.ReadLine();

        List<string> fruits = new List<string>
        {
            "banana", "apple", "plum", "orange", "grape"
        };
        Console.WriteLine("Pick a fruit");
        string pick = Console.ReadLine();
        foreach (string fruit in fruits)
        {
            if (fruits.Contains(pick))
            {
                Console.WriteLine("That fruit is in the list");
            }
            else
            {
                Console.WriteLine("That fruit is not in the list");
                break;
            }
        }
        Console.ReadLine();


        List<string> desserts = new List<string>
        {
            "shortbread", "cookies", "icecream", "pumpkinpie", "cake", "brownies", "cake", "danish"
        };
        Console.WriteLine("What dessert do you prefer the most");
        string sweets = Console.ReadLine();
        foreach (string sweet in desserts)
        {
            if (desserts.Contains(sweets))
            {
                Console.WriteLine(sweets + " is is in the list");
                break;
            }
            else
            {
                Console.WriteLine(sweets + " is not in the list");
                break;
            }
        }
        for (int i = 0; i < desserts.Count(); i++)
        {
            Console.WriteLine(desserts[i]);
        }
        Console.ReadLine();

        // Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.
        List<string> myTeams = new List<string>
            {
                "Lakers", "Dolphins", "Mariners", "Kings", "Seminoles", "Brazil", "Dolphins", "Lakers"
            };
        List<string> snubs = new List<string>();
        Console.WriteLine("Choose a team");
        string select = Console.ReadLine();
        // The foreach is creating a local string in the variable list myTeams.
        foreach (string team in myTeams)
        {
            // C# if Statement The if statement contains a boolean condition followed by a single or multi-line code block to be executed.
            if (snubs.Contains(team))
            {
                Console.WriteLine(team + " team is a duplicate in list ");
            }
            else // An else statement is used with if statement to execute some block of code if the given condition is false.
            {
                Console.WriteLine(team + " team is not a duplicate");
                // Add strings together, appending them, with the plus operator.
                snubs.Add(team);
            }
        }

        //if (myTeams.Contains(select))
        //{
        //    for (int i = 0; i < myTeams.Count(); i++)
        //    {
        //        if (myTeams[i] == select)
        //        {
        //            Console.WriteLine(i);
        //        }
        //        foreach (string team in myTeams)
        //        {
        //            //If the item does not exist, add it to "snubs"
        //            if (!snubs.Contains(team))
        //            {
        //                snubs.AddRange(myTeams);
        //            }
        //        }
        //        foreach (myTeams)
        //        {
        //            if(team != select)
        //            {
        //                Console.WriteLine("This team is appears multiple times");
        //            }
        //            else
        //            {
        //                Console.WriteLine("This team appears once");
        //            }
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Team not in list");
        //}
        ////Display items in the list
        //foreach (string loss in snubs)
        //{
        //    Console.WriteLine("A fan of the {0}", loss);
        //}



        Console.ReadLine();
    } 
    }
