using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ATM
{
    Client client;
    public ATM(Client client)
    {
        this.client = client;
    }

    public void PrintBalance()
    {
        Console.WriteLine(client.Balance);
    }

    public void Deposit(double deposit)
    {
        this.client.Balance += deposit;
    }

    public void Withdraw(double withdrawal)
    {
        this.client.Balance -= withdrawal;
    }

    public void Greet()
    {
        Console.WriteLine($"Greetings, {client.FirstName} {client.LastName}! Please select from our options down below.");
    }
}
