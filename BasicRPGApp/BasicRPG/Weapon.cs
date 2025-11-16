using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG
{
    // Remove the nested Weapon class and define Weapon as a top-level class
    public class Weapon : Item
    {
        public double Damage { get; set; }
        public double BonusDmg { get; set; }
        public string? Type { get; set; }

        public Weapon(int id, string name, int value, double itemWeight, string description, int quantity, double damage, double bonusDmg, string type)
            : base(id, name, value, itemWeight, description, quantity)
        {
            Damage = damage;
            BonusDmg = bonusDmg;
            Type = type;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Damage: {Damage}, Bonus Damage: {BonusDmg}, Type: {Type}";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Weapon: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Damage: {Damage}");
            Console.WriteLine($"Bonus Damage: {BonusDmg}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Value: {Value}");
            Console.WriteLine($"Item Weight: {ItemWeight}");
            Console.WriteLine();
        }

        public void WeaponAttack(int baseDamage)
        {
            double totalDamage = Damage + (BonusDmg * baseDamage);
            Console.WriteLine($"{Name} deals {totalDamage} total damage!\n");
        }
    }
}
