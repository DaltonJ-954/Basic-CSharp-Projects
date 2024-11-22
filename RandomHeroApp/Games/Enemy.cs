using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RandomHeroApp.Games
{
    public class Enemy : Character
    {
        public int Value { get; set; }
        public string? Description { get; set; }
        public Enemy(string name, int level, int health, int attackPower, int defense) : base(name, level, health, attackPower, defense)
        {

        }

        public void Attack(Enemy target)
        {
            int damage = AttackPower - target.Defense;
            if (damage > 0)
            {
                target.Health -= damage;
                Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{Name}'s attack was too weak to harm {target.Name}.");
            }
        }

        public void DropLoot(Character player)
        {
            Random random = new Random();
            // Example loot drop
            var loot = new Item("Gold Coins", 30, random.Next(1, 110), "A pile of gold that was dropped by the enemy.");
            if (loot.Value > 1)
            {
                player.Inventory.AddItem(loot);
                Console.WriteLine($"{Name} drops loot, and reveals... {loot.Description} valued at {loot.Value} pieces.");
            }
            else
            {
                Console.WriteLine($"{player.Name} has found {loot.Value} gold coin.");
            }
        }
    }
}
