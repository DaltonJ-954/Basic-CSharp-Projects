using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RandomHeroApp.Games
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public int AttackBonus { get; set; }
        double Weight { get; set; }

        public Weapon(string name, int quantity, int value, string description, int damage, int attackBonus, double weight) : base(name, quantity, value, description)
        {
            Damage = damage;
            AttackBonus = attackBonus;
            Weight = weight;
        }

        public override void Use(Character character)
        {
            character.AttackPower += AttackBonus;
            Console.WriteLine($"{character.Name} equips {Name} and gains {AttackBonus} attack power.");
        }
    }
}
