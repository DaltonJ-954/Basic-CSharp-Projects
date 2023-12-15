using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        String[] vehicle = new string[4];



        int a, b, c;
        a = 10; b = 50;
        c = a * b % a;

        int f1(int a, int b) { return (a > b ? a : b); }

        List<string> food = new List<string>();
        food.Add("pizza");
        food.Add("steak");
        food.Add("soup");
        food.Add("tacos");

        Console.WriteLine(food[3]);
        Console.ReadLine();

        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        // Both methods yield the same results. Except this way is cleaner.
        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 48, 345, 2100 };

        // This is an even a more cleaner line of code.
        int[] numArray2 = { 5, 2, 10, 200, 5000, 48, 345, 2100 };
        numArray2[0] = 23;

        // This allows you to modify data in individual indexs.

        Console.WriteLine(vehicle[1]);
        Console.WriteLine(numArray2[0]);
        Console.WriteLine(c);
        Console.WriteLine((a > b ? a : b));
        Console.ReadLine();

    } 
}
