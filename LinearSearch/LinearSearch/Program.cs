using System;
using System.Collections;
using System.Collections.Generic;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue(10);
            myQueue.Enqueue(10);
            myQueue.Enqueue(10);
            myQueue.Enqueue(10);
            myQueue.Enqueue(10);
            myQueue.Enqueue(10);
            myQueue.Enqueue(10);

            Console.WriteLine($"This queue has a total of " + myQueue.Count + " that's documented.");

            if (myQueue.Count == 5)
            {
                Console.WriteLine($"We found {myQueue.Count} to be the correct number.");
            }
            if (myQueue.Count > 8)
            {
                Console.WriteLine($"{myQueue.Count} queues is out of range.");
            }
            if (myQueue.Count < 3)
            {
                Console.WriteLine($"The queue of {myQueue.Count} is not sufficient.");
            }

            int[] array = { 6, 9, 7, 4, 8, 3, 2, 5, 1 };

            int index = linearSearch(array, 5);

            if (index != -1)
            {
                Console.WriteLine("Element found at index: " + index);
            }
            else
            {
                Console.WriteLine("Element not found.");
            }Console.ReadKey();


            string[] sportType = new string[5];

            sportType[0] = "football";
            sportType[1] = "softball";
            sportType[2] = "tennis";
            sportType[3] = "golf";
            sportType[4] = "hockey";

            foreach (string sport in sportType)
            {
                Console.WriteLine(sport);
            }
            Console.ReadKey();


            List<String> sports = new List<String>();

            sports.Add("Football");
            sports.Add("Baseball");
            sports.Add("Golf");
            sports.Add("Tennis");
            sports.Add("Rugby");
            sports.Add("Soccer");
            sports.Add("Basketball");
            sports.Add("Boxing");

            sports.Insert(2, "Hockey");
            sports.Remove("Soccer");

            Console.WriteLine(sports.Count);

            foreach (string sport in sports)
            {
                Console.WriteLine(sport);
            }
            Console.ReadKey();
        }

        private static int linearSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
