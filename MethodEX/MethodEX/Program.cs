using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 34, 12, 5, 66, 1, 98, 23, 7 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        BubbleSort(numbers);

        Console.WriteLine("\nSorted array:");
        PrintArray(numbers);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swapped = true;
                }
            }

            // If no two elements were swapped in the inner loop, array is sorted
            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
