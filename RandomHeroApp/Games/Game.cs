using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHeroApp.Games
{
    public class Game
    {
        public Character Player { get; set; }

        public Game(Character player)
        {
            Player = player;
        }

        public void Start()
        {
            Console.WriteLine($"Welcome, {Player.Name}, to the RPG!");
            // Game loop or story events
        }

        public void Battle(Enemy enemy)
        {
            static Enemy RandomlyPickUnit(Random random, Enemy specters, Enemy necrophages, Enemy ogroids)
            {
                // Generates a random number 0 or 1
                int randomValue = random.Next(3);
                // Returns specters if randomValue is 0, otherwise returns necrophages
                if (randomValue == 2)
                {
                    return ogroids;
                }
                return randomValue == 0 ? specters : necrophages;
            }

            Console.WriteLine($"A wild {enemy.Name} appears!");

            while (Player.IsAlive() && enemy.IsAlive())
            {
                Enemy enemyTarget = new()
                Console.WriteLine("Your turn to attack!\n");
                if (enemy.IsAlive())
                {
                    Player.Attack(enemy);
                    Console.WriteLine($"{enemy.Name} health is now {enemy.Health}\n");
                }

                Console.WriteLine("It's the enemy's turn.\n");

                if (Player.IsAlive())
                {
                    enemy.Attack(Player);
                    Console.WriteLine($"{Player.Name} health is currently {Player.Health}\n");

                    Console.ReadKey();
                }
            }

            if (Player.IsAlive())
            {
                Console.WriteLine($"{Player.Name} has defeated {enemy.Name}!\n");
                enemy.DropLoot(Player);
            }
            else if (enemy.IsAlive()) 
            {
                Console.WriteLine($"{enemy.Name} was defeated by {Player.Name}...\n");
            }
        }
    }
}
