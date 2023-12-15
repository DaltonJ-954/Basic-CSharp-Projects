using System;

namespace MultipleInterfaces
{

    interface Drums // Interface method
    {
        void drummer();
    }

    interface Guitar // Second interface method
    {
        void guitarist();
    }

    interface Piano // Second interface method
    {
        void pianist();
    }

    // The implementation of multiple interface methods. These methods still work without being implemented to the Band class.
    class Band : Drums, Guitar, Piano
    {
        public void drummer()
        {
            Console.WriteLine("The drums go bip bop BAMMMM!!!");
        }

        public void guitarist()
        {
            Console.WriteLine("Narrnnnggghhh Narrnnnggghhh Narrnnnggghhhhhhhh goes the guitar!");
        }

        public void pianist()
        {
            Console.WriteLine("The keys, as they are being pressed sounds so elagant and heavenly to the ears.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Band musical = new Band();
            Band band = new Band();
            band.guitarist();
            musical.drummer();
            musical.drummer();
            musical.drummer();
            musical.guitarist();
            musical.pianist();

            Console.ReadKey();
        }
    }
}
