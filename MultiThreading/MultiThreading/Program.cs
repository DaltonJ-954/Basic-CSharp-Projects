using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thread class is used to create threads.
            // With the help of Thread class you can create foreground and background thread.
            // Thread class allows you to set the priority of a thread.
            // It also provides you the current state of a thread.
            // It provides the reference of the current executing thread.
            // It is a sealed class, so it cannot be inherited.

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            // Console.WriteLine(mainThread.Name);

            CountDown();
            CountUp();

            Console.WriteLine(mainThread.Name + " is complete!");

            Console.ReadKey();
        }
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--) // Counter that subtracts 1 number at a time from an "i" variable with a value of 10.
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++) // Counter that adds 1 number at a time up to 10 from an "i" variable that starts with a value of 0.
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(3000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }

    }
}
