using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGames
{
    class GameList : Game
    {
        private List<Game> games = new List<Game>();

        public void AddGame(Game game)
        {
            games.Add(game);
        }

        public void ListGames()
        {
            Console.WriteLine("Game List:");
            foreach (var game in games)
            {
                Console.WriteLine($"Title: {game.Title}, Genre: {game.Genre}, Platform: {game.Platform}");
            }
        }

        public bool DeleteGame(string gameName)
        {
            var gameToRemove = games.FirstOrDefault(g => g.Title.Equals(gameName, StringComparison.OrdinalIgnoreCase));

            if (gameToRemove != null)
            {
                games.Remove(gameToRemove);
                return true;
            }
            return false;
        }
    }
}
