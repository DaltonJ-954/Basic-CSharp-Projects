using RandomHeroApp.Games;

namespace RandomHeroApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character("Hero", 1, 120, 18, 12);
            Game game = new Game(player);

            game.Start();

            Enemy villian = new Enemy("Goblin", 1, 100, 20, 5);
            game.Battle(villian);
        }
    }
}
