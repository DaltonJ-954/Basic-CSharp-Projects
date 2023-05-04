using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> inList = new List<string>();
        inList.Add("Hello");
        inList.Add("Tech");
        inList.Add("Academy!");

        Console.WriteLine(inList[0]);
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

        Console.WriteLine(numArray1[3]);
        Console.WriteLine(numArray2[0]);
        Console.ReadLine();

    }
}
