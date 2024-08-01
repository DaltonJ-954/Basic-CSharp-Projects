using System;

namespace ConsoleGames
{
    class Program
    {
        static void Main(string[] args)
        {
            GameList gameList = new GameList();

            while (true)
            {
                Console.WriteLine("Game List App\n");
                Console.WriteLine("1. Add Game");
                Console.WriteLine("2. List Games");
                Console.WriteLine("3. Delete Game");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Select an Option\n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the title: \n");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the genre: \n");
                        string genre = Console.ReadLine();
                        Console.WriteLine("Enter the system: \n");
                        string platform = Console.ReadLine();

                        Game newGame = new Game
                        {
                            Title = title,
                            Genre = genre,
                            Platform = platform,
                        };

                        gameList.AddGame(newGame);
                        break;

                    case "2":
                        gameList.ListGames();
                        if (gameList == null)
                        {
                            Console.WriteLine("There are no games currently listed.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter game to delete: \n");
                        var remove = Console.ReadLine();

                        Game game = new Game()
                        {
                            Title = ""
                        };

                        gameList.DeleteGame(remove);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }
    }
}
