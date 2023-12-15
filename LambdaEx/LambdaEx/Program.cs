using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameList = new List<Game> {
               new Game{Name = "Mario Wonder", ReleaseDate = new DateTime(2023,10,20), SteamScore = 9},
               new Game{Name = "Spiderman 2", ReleaseDate = new DateTime(2023,10,20), SteamScore = 8},
               new Game{Name = "Star Wars: Jedi Survivor", ReleaseDate = new DateTime(2023,4,28), SteamScore = 9},
               new Game{Name = "God of War: Ragnorok", ReleaseDate = new DateTime(2022,11,9), SteamScore = 10},
               new Game{Name = "Final Fantasy 16", ReleaseDate = new DateTime(2023,6,22), SteamScore = 8},
               new Game{Name = "Diablo 4", ReleaseDate = new DateTime(2023,6,5), SteamScore = 9},
               new Game{Name = "Wo Long: Fallen Dynasty", ReleaseDate = new DateTime(2023,3,3), SteamScore = 9},
               new Game{Name = "TLOZ: Tears of the Kingdom", ReleaseDate = new DateTime(2023,5,12), SteamScore = 10},
               new Game{Name = "Street Fighter 6", ReleaseDate = new DateTime(2023,6,2), SteamScore = 8},
               new Game{Name = "Fire Emblem: Engage", ReleaseDate = new DateTime(2023,1,20), SteamScore = 7},
               new Game{Name = "Resident Evil 4: Remake", ReleaseDate = new DateTime(2023,5,24), SteamScore = 8},
           };

            bool scoreEqualOrBetterThan8 = gameList.All(g => g.SteamScore >= 8);

            IEnumerable<string> gameTitles = gameList.Select(g => g.Name).ToList();

            Game gameEqualTo7 = gameList.First(g => g.SteamScore == 7);

            Console.WriteLine(gameList);
        }
    }
}