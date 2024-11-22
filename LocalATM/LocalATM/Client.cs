using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Client
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int AccountNum { get; set; }
    public int Pin { get; set; }
    public double Balance { get; set; }

    public Client(string firstName, string lastName, int accountNum, int pin, double balance)
    {
        FirstName = firstName;
        LastName = lastName;
        AccountNum = accountNum;
        Pin = pin;
        Balance = balance;
    }
}
