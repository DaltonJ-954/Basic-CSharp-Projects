using System;
using System.Collections.Generic;

namespace Car_InventoryApp
{
    class CarStockApp
    {
        private List<CarLot> inventory;

        public CarStockApp()
        {
        }

        public CarStockApp(CarLot carLot)
        {
            inventory = new List<CarLot>();
        }

        public void AddCar()
        {
            Console.WriteLine("Enter car details: ");
            Console.WriteLine("Make: \n");
            string make = Console.ReadLine();

            Console.WriteLine("Model: \n");
            string model = Console.ReadLine();

            Console.WriteLine("Color: \n");
            string color = Console.ReadLine();

            Console.WriteLine("Year: \n");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantity: ");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer for quanity.");
                Console.WriteLine("Quantity: ");
            }

            CarLot newCar = new CarLot() { Make = make, Model = model, Color = color, Year = year, Quantity = quantity };
            inventory.Add(newCar);

            Console.WriteLine("Car was added to inventory.");
        }

        public void ViewInventory()
        {
            Console.WriteLine("\nCar Inventory: ");
            foreach (var car in inventory)
            {
                if (true)
                {
                    Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Color: {car.Color}, Year: {car.Year}, Quantity: {car.Quantity}");
                }
            }
        }


    }
}
