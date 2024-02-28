using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class DynamicArray
    {
        int size;
        int capacity;
        Object[] array;

        public DynamicArray()
        {
            this.array = new Object[capacity];
        }

        public DynamicArray(int capacity)
        {
            this.capacity = capacity;
            this.array = new Object[capacity];
        }
    }

    ////public void BubbleSort<T>(List<T> list)
    ////{
    ////    BubbleSort<T>(list, Comparer<T>.Default);
    ////}

    ////public void BubbleSort<T>(List<T> list, IComparer<T> comparer)
    ////{
    ////    bool stillGoing = true;
    ////    while(stillGoing)
    ////    {
    ////        stillGoing = false;
    ////        for (int i = 0; i < list.Count - 1; i++)
    ////        {
    ////            T x = list[i];
    ////            T y = list[i + 1];
    ////            if (comparer.Compare(x, y) > 0)
    ////            {
    ////                list[i] = y;
    ////                list[i + 1] = x;
    ////                stillGoing = true;
    ////            }
    ////        }
    ////    }
    //}
    public static void Main(String[] args)
    {
        var array1 = new[] { 4, 7, 14, 31, 29, 2 };
        var array2 = new[] { 2, 9, 14, 27, 31, 4 };

        var array = array1.Union(array2).ToArray();

        Console.WriteLine(array.Length);
        Console.ReadKey();

        int[,] degrees = { { 24, 65, 44, -1, 0, 83 }, { 76, 34, 448, -80, 03, 25 }, { 5, 78, 745, 21, 35, 7 } };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine($" " + degrees[i, j]);
            }
        }
        Console.WriteLine(degrees.GetEnumerator());

        DynamicArray dynamic = new DynamicArray();

        Stack<String> stack = new Stack<String>();

        stack.Push("Horizon West");
        stack.Push("Zelda: TotK");
        stack.Push("Metroid Prime 4");
        stack.Push("Star Wars: Jedi Master");
        stack.Push("Dead Cells");
        stack.Push("Halo");

        Console.WriteLine(stack.Count);

        Stack<Double> Age = new Stack<double>();

        Age.Push(65);
        Age.Push(21);
        Age.Push(5);
        Age.Push(78);
        Age.Push(25);
        Age.Push(32);
        Age.Push(39);
        Age.Push(41);

        Console.WriteLine(Age);

        Console.WriteLine(Age.Pop());

        Queue<String> customer = new Queue<string>();

        customer.Enqueue("Karen");
        customer.Enqueue("Jake");
        customer.Enqueue("Laurie");
        customer.Enqueue("Natasha");

        customer.Dequeue();
        customer.Dequeue();
        customer.Enqueue("Paul");
        customer.Enqueue("Nontle");
        customer.Enqueue("Simba");
        customer.Enqueue("Andrew");

        Console.WriteLine(customer.Equals("Simba"));

        Console.WriteLine(customer.Count);

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
        Console.WriteLine(numArray2[0]);
        Console.WriteLine(c);
        Console.WriteLine((a > b ? a : b));
        Console.ReadLine();
    } 
}
