using System;

class Program
{
    static void Main(string[] args)
    {
        // List class can be used to create a collection of different types like integers, strings etc.
        int[] numList = { 34, 22, 5, 10, 55, 2, 83, 25, 40, 13 };
        // The try statement allows you to define a block of code to be tested for errors while it is being executed.
        try
        {
            // Console.WriteLine  is used to print data along with printing the new line.
            Console.WriteLine("Pick a number");
            // Convert class provides different methods to convert a base data type to another base data type.
            int numberOne = Convert.ToInt32(Console.ReadLine());
            // Integer Methods are generally the block of codes or statements in a program that gives the user the ability to reuse the same code
            // which ultimately saves the excessive use of memory
            int i = 0;
            // The while loop loops through a block of code as long as a specified condition is True:
            while (i != numList.Length)
            {
                Console.WriteLine(numberOne / numList[i]);
                i++;
            }
            // This method is used to read the next line of characters from the standard input stream.
            Console.ReadLine();
        }
        // The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        // The finally statement lets you execute code, after try...catch, regardless of the result:
        finally
        {
            Console.ReadLine();
        }
    }
   }
