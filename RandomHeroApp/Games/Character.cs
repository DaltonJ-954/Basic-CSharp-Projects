using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHeroApp.Games
{
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        public Inventory Inventory { get; set; }

        public Character(string name, int level, int health, int attackPower, int defense)
        {
            Name = name;
            Level = level;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
            Inventory = new Inventory();
        }

        public void Attack(Character target)
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

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} heals for {amount} health.");
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}
