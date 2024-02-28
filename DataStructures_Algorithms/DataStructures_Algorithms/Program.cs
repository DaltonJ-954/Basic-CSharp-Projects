using System;

namespace DataStructures_Algorithms
{
    class Program
    {
        // Insertions & Deletions of Arrays
        static void Main(string[] args)
        {
            //Arrays are not very good at Insertions
            int[] intArray = new int[10];

            //Make a variable to keep the length because .Length is based off capacity and does track the actual index
            int length = 0;

            //This adds data into the variable "length" for us
            for (int i = 0; i < 8; i++)
                {
                    // Added +1 to the intArray[length] for loop so when iterating from the beginning adds 1 instead of 0
                    intArray[length] = i + 1;
                    length++;
                }

            intArray[length] = 9;
            length++;

            //Inserting at the start of an array

            for (int i = 3; i >= 0; i--)
            {
                // This code is moving over all the values
                intArray[i + 1] = intArray[i];
            }

            intArray[0] = 15;
            int value = 0;

            //Shifting the index / element
            for (int i = 4; i >= 2; i--)
            {
                // SHift each element one position to the right
                intArray[i + 1] = intArray[i];
            }

            intArray[2] = 10;

            int value2 = 0;


            //Deletions from back, start, or anywhere in the aray

            int[] theArray = new int[9];

            int lengthArr = 0;

            for (int i = 0; i < 6; i++)
            {
                theArray[lengthArr] = i;
                lengthArr++;
            }

            //Deleting from the start of an array
            //lengthArr--;

            for (int i = 1; i < lengthArr; i++)
            {
                theArray[i - 1] = theArray[i];
            }

            //Deleting from the back of an array
            lengthArr--;

            for (int i = 0; i < lengthArr; i++)
            {
                Console.WriteLine(theArray[i]);
            }

            //Deleting from anywhere in the array

            for (int i = 5; i < lengthArr; i++)
            {
                theArray[i - 1] = theArray[i];
            }

            lengthArr--;

            for (int i = 0; i < lengthArr; i++)
            {
                Console.WriteLine(theArray[i]);
            }

            // Linear search array
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Key means what value we are searching for
            bool LinearSearch(int[] array, int key)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == key)
                    {
                        return true;
                    }
                }

                return false;
            }
            Console.WriteLine(LinearSearch(array, 0));
        }
    }
}
