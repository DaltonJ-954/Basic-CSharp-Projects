using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHeroApp.Games
{
    public class Item : Inventory
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        
        public Item(string name, int quantity, int value, string description)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Value = value;
            this.Description = description;
        }

        public virtual void Use(Character character)
        {
            Console.WriteLine($"{character.Name} uses {Name}.");
        }
    }
}
