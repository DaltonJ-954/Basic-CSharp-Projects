using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHeroApp.Games
{
    public class Inventory
    {
        public List<Item> Items { get; private set; }

        public Inventory()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
            Console.WriteLine($"{item.Name} added to inventory.");
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
            Console.WriteLine($"{item.Name} removed from inventory.");
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in Items)
            {
                Console.WriteLine($"- {item.Name}");
            }
        }
    }
}
