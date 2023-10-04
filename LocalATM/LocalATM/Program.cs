using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        // Check for account number.
        //Check for pin
        List<Client> clients = new List<Client>();
        clients.Add(new Client("Jacob", "Morales", 47376060, 7210, 900.00));
        clients.Add(new Client("Mike", "Lawery", 47374530, 9324, 150.56));
        clients.Add(new Client("Corey", "Holcombe", 47370912, 5652, 900.00));
        clients.Add(new Client("Jerry", "Springer", 47374523, 0133, 470.45));
        clients.Add(new Client("Jamie", "Foxx", 47371298, 1200, 234.12));
        clients.Add(new Client("Brandon", "Ingraham", 47374444, 3278, 677.79));
        clients.Add(new Client("Michael", "Jordan", 47370915, 3278, 1450299.79));

        Console.WriteLine("Welcome! Please enter your account number: ");

        Client client;
        int AccountNum;

        while (true)
        {
            AccountNum = int.Parse(Console.ReadLine());
            client = clients.FirstOrDefault(client => client.AccountNum == AccountNum);
            if (client != null) { break; }
            else { Console.WriteLine("Incorrect account number, please try again: "); }
        }

        Console.WriteLine("Please enter your pin: ");

        int pin = 0;

        while (true)
        {
            pin = int.Parse(Console.ReadLine());
            if (client.Pin == pin) { break; }
            else { Console.WriteLine("Incorrect pin. Please try again: "); }
        }

        ATM atm = new ATM(client);

        atm.Greet();
        int option = 0;

        // While loop statement through the PrintATMOptions
        while (true)
        {
            PrintATMOptions();
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine();
                Console.WriteLine("How much would you like to deposit?");
                double deposit = Double.Parse(Console.ReadLine()); // Deposit = deposit method with the += operator to add to balance
                atm.Deposit(deposit);
                Console.WriteLine($"Thank you {client.FirstName}! Your money has been deposited to your account.\n");
                Console.WriteLine($"Your new balance is: {client.Balance}");
            }
            else if (option == 2)
            {
                Console.WriteLine();
                Console.WriteLine("How much would you like to withdraw?");
                double withdrawal = Double.Parse(Console.ReadLine()); // Withdraw = withdrawal method with the -= operator to subtract from balance
                if (client.Balance < withdrawal || client.Balance - withdrawal < 0)
                {
                    Console.WriteLine("Insufficient balance. Please try again.");
                }
                else
                {
                    atm.Withdraw(withdrawal);
                    Console.WriteLine("Thank you! Your money has been withdrawn from your account.\n");
                    Console.WriteLine($"Your new balance is: {client.Balance}");
                }
            }
            else if (option == 3)
            {
                Console.WriteLine();
                atm.PrintBalance();
            }
            else if (option == 4)
            {
                Console.WriteLine("Thank you for banking at LocalATM. Goodbye!");
                break;
            }
            else { option = 0; }
        }
    }

    public static void PrintATMOptions()
    {
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Check Balance");
        Console.WriteLine("4. Exit");
    }
}
