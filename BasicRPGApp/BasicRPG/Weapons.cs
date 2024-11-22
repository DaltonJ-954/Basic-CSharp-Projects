using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG
{
    public class Weapon : Item
    {
        public double Damage { get; set; }
        public double BonusDmg { get; set; }
        public string? Type { get; set; }

        public Weapon(int id, string name, int value, double itemWeight, string description, int quantity, double damage, double bonusDmg, string type) 
            : base(id, name, value, itemWeight, description, quantity)
        {
            this.Damage = damage;
            this.BonusDmg = bonusDmg;
            this.Type = type;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Damage: {Damage} Bonus Damage: {BonusDmg} Weapon Type: {Type}";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Weapon: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Damage: {BonusDmg}\n");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Value: {Value}");
            Console.WriteLine($"Item Weight: : {ItemWeight}");
        }

        public void WeaponAttack(int damage)
        {
            if (damage >= Damage)
            {
                Damage = Damage * BonusDmg + damage;
            }
            Console.WriteLine($"{Name} deals {Damage} damage.\n");
        }
    }
}
