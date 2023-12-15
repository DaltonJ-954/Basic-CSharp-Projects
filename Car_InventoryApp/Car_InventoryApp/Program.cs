using System;

namespace Car_InventoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CarStockApp stockApp = new CarStockApp();
                CarLot carLot = new CarLot();

                Console.WriteLine("\nCar Inventory Application");
                Console.WriteLine("1. Add car: ");
                Console.WriteLine("2. View Inventory: ");
                Console.WriteLine("3. Exit the app");
                Console.WriteLine("\nEnter your selection: ");

                string select = Console.ReadLine();

                switch (select)
                {
                    case "1":
                        stockApp.AddCar();
                        break;
                    case "2":
                        stockApp.ViewInventory();
                        break;
                    case "3":
                        var stock = carLot.Quantity;
                        if (carLot.Quantity < stock || carLot.Quantity - stock < 0)
                        {
                            Console.WriteLine("This car selection is not in stock. Please choose from our other models.");
                        }
                        else
                            carLot.RemoveInventory(stock);
                        break;
                    case "4":
                        Console.WriteLine("Application is closing. Goodbye.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Please choose from the options.");
                        break;
                }
            }
        }
    }
}
