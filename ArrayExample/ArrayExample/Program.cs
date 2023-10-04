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
        Console.WriteLine("What is your favorite type of animal? ");
        // The string fav is created for user input.
        string fav = Console.ReadLine();
        // The foreach statement executes a statement or a block of statements for each element in an instance of the type
        for (int i = 0; i != animals.Length; i++)
            // In C#, if statement is used to indicate which statement will execute according to the value of the given boolean expression
            {
            animals[i] = animals[i] + fav;
            }
        // The for statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. 
        for (int a = 0; a != animals.Length; a++)
        {
            Console.WriteLine(animals[a]);
        }
        // This is a loop that results in a loop using the leass than(<) sign.
        while (animals.Length > 5)
        {
            Console.WriteLine("To infininty and beyond!");
        }
        // Reads the next line of characters from the standard input stream.
        Console.ReadLine();

        List<string> fruits = new List<string>
        {
            "banana", "apple", "plum", "orange", "grape"
        };
        Console.WriteLine("Pick a fruit");
        // The string pick is created for user input.
        string pick = Console.ReadLine();
        for (int x = 0; x < fruits.Count; x++)
        {
            if (fruits[x] == pick)
            {
                // This block of code adds an index number equal to the user input string pick.
                Console.WriteLine("Your item is found at index:" + x);
                break;
            }
        }
        // A not statement that's declaring a user input string isn't in the fruits list.
        if (!fruits.Contains(pick))
        {
            Console.WriteLine("Match is not found");
        }
        Console.ReadLine();               

        List<string> desserts = new List<string>
        {
            "shortbread", "cookies", "icecream", "pumpkinpie", "cake", "brownies", "cake", "danish"
        };

        for (int i = 0; i < desserts.Count(); i++)
        {
            // A for loop that is reading through the list of strings in the desserts list of arrays.
            Console.WriteLine(desserts[i]);
        }
        Console.WriteLine("What dessert do you prefer the most");
        // The string sweets is created for user input.
        string sweets = Console.ReadLine();
        for (int t = 0; t < desserts.Count; t++)
        {
            if (desserts[t] == sweets)
            {
                // A local variable being concotenated int a string with and int (t).
                Console.WriteLine(sweets + " is in the list " + t);
            }
        }
        if (!desserts.Contains(sweets))
        {
            Console.WriteLine("This is not in the list");
        }
        Console.ReadLine();

        // Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.
        List<string> myTeams = new List<string>
            {
                "Lakers", "Dolphins", "Mariners", "Kings", "Seminoles", "Brazil", "Dolphins", "Lakers"
            };
        List<string> snubs = new List<string>();
        Console.WriteLine("Choose a team");
        // The string select is created for user input.
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
        Console.ReadLine();
    } 
    }
