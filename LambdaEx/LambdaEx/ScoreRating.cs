using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaEx
{
    class ScoreRating : Game
    {
        public string Name;
        public double SteamScore;
        public double ReleaseDate;
        public double Stars;

        List<Game> games = new List<Game>();

        public void ign()
        {
            Console.WriteLine(Name, ReleaseDate, SteamScore);
        }
    }
}