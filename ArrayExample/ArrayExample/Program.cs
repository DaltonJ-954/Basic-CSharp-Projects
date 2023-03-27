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

        //Console.WriteLine("What show does Andrew Lincoln start in?");
        //string shows = Convert.ToString(Console.ReadLine());
        //bool correct = shows == "TWD";

        //    switch (shows)
        //    {
        //        case "Invincible":
        //            Console.WriteLine("Even thogh it's possible, I doubt he had time to do voice acting..");
        //            Console.WriteLine("Guess again?");
        //            shows = Convert.ToString(Console.ReadLine());
        //            break;
        //        case "Game of Thrones":
        //            Console.WriteLine("He never even made a guess appearance in that show. Odd choice.");
        //            Console.WriteLine("Guess again?");
        //            shows = Convert.ToString(Console.ReadLine());
        //            break;
        //        case "TWD":
        //            Console.WriteLine("That is right. He was the main character of the show. Great guess!");
        //        correct = true;
        //            break;
        //        case "Seinfield":
        //            Console.WriteLine("Really? In what world did that happen?");
        //            Console.WriteLine("Guess again?");
        //            shows = Convert.ToString(Console.ReadLine());
        //            break;
        //        case "default":
        //            Console.WriteLine("Not even close!");
        //            Console.WriteLine("Guess again?");
        //            shows = Convert.ToString(Console.ReadLine());
        //            break;
        //        case "Friends":
        //            Console.WriteLine("Andrew has the gift of laughter now? Doubt it.");
        //            Console.WriteLine("Guess again?");
        //            shows = Convert.ToString(Console.ReadLine());
        //            break;
        //    }
        //while (!correct);
        //Console.ReadLine();



        List<string> myTeams = new List<string>
            {
                "Lakers", "Dolphins", "Mariners", "Kings", "Seminoles", "Brazil", "Dolphins"
            };
        List<string> snubs = new List<string>();
        myTeams.Add("Dodgers");
        myTeams.Add("Heat");
        myTeams.Add("Lakers");
        Console.WriteLine("Choose a team");
        string select = Console.ReadLine();

        if (myTeams.Contains(select))
        {
            for (int i = 0; i < myTeams.Count(); i++)
            {
                if (myTeams[i] == select)
                {
                    Console.WriteLine(i);
                }
                foreach (string team in myTeams)
                {
                    //If the item does not exist, add it to "snubs"
                    if (!snubs.Contains(team))
                    {
                        snubs.AddRange(myTeams);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Team not in list");
        }
        //Display items in the list
        foreach (string loss in snubs)
        {
            Console.WriteLine("A fan of the {0}", loss);
        }
        Console.ReadLine();
    } 
    }
