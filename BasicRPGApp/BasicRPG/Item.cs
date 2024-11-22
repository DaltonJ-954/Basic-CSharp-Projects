using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Value { get; set; }
        public double ItemWeight { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }

        public Item(int id, string name, int value, double itemWeight, string description, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.Value = value;
            this.ItemWeight = itemWeight;
            this.Description = description;
            this.Quantity = quantity;
        }

        public void ItemDisplay()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Value: {Value}");
            Console.WriteLine($"Weight of Item: {ItemWeight}\n");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Quantity: {Quantity}");
        }

        public override string? ToString()
        {
            return $"{Name}: {Description}\n`";
        }
    }
}
