using System;
using System.Collections.Generic;
using System.Text;

namespace Car_InventoryApp
{
    class CarLot
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Quantity { get; set; }

        public CarLot(string make, string model, string color, int year, int quantity)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Quantity = quantity;
        }

        public CarLot(int quantity)
        {

        }

        public CarLot()
        {
        }

        public void RemoveInventory(int remove)
        {
            this.Quantity -= remove;
        }
    }
}
