using System;
using System.Collections;

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
            myQueue.Enqueue(10);
            myQueue.Enqueue(10);
            myQueue.Enqueue(10);

            Console.WriteLine($"This queue has a total of " + myQueue.Count + " that's documented.");

            if (myQueue.Count == 8)
            {
                Console.WriteLine($"We found {myQueue.Count} to be the correct number.");
            }
            if (myQueue.Count > 8)
            {
                Console.WriteLine($"{myQueue.Count} queues is out of range.");
            }
            if (myQueue.Count < 8)
            {
                Console.WriteLine($"The queue of {myQueue.Count} is not sufficient.");
            }

            int[] array = { 6, 9, 7, 4, 8, 3, 2, 5, 1 };

            int index = linearSearch(array, 2);

            if (index != -1)
            {
                Console.WriteLine("Element found at index: " + index);
            }
            else
            {
                Console.WriteLine("Element not found.");
            }
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
