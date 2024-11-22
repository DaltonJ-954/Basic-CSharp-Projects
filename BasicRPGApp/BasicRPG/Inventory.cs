using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG
{
    public class Inventory 
    {
        private readonly List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            var currentItem = items.FirstOrDefault(item => item.Id == item.Id);
            if (currentItem != null)
            {
                currentItem.Quantity += item.Quantity;
            }
            else
            {
                items.Add(item);
                Console.WriteLine("New entry!");
            }
        }

        public bool RemoveItem(int id, int quantity)
        {
            var item = items.FirstOrDefault(item => item.Id == id);
            if (item != null && item.Quantity >= quantity)
            {
                item.Quantity -= quantity;
                if (item.Quantity == 0)
                {
                    items.Remove(item);
                }
                return true;
            }
            return false;
        }

        public Item? ViewItemById(int id)
        {
            return items.FirstOrDefault(item => item.Id == id);
        }

        public int ItemTotalValue()
        {
            return items.Sum(item => item.Value * item.Quantity);
        }

        public double GetTotalWeight()
        {
            return items.Sum(i => i.ItemWeight * i.Quantity);
        }

        public void DisplayInventory()
        {
            Console.WriteLine("-- Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"You have {item} in your inventory.\n");
            }
        }
    }
}