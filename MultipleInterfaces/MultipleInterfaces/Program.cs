using System;

namespace MultipleInterfaces
{

    interface IViolin // Interface method
    {
        void Violinist();
    }

    interface IFlute // Second interface method
    {
        void Flutistist();
    }

    interface IPiano // Third interface method
    {
        void Pianist();
    }

    // The implementation of multiple interface methods. These methods still work without being implemented to the Orhestrator class.
    class Orhestrator : IViolin, IFlute, IPiano
    {
        public void Violinist()
        {
            Console.WriteLine("The strings have a very distinct and precise sound. It cuts in spots that need an impactful punch.");
        }

        public void Flutistist()
        {
            Console.WriteLine("The flute gives a very soothing melody.");
        }

        public void Pianist()
        {
            Console.WriteLine("The keys as they are being pressed sound so elagant and heavenly to the ear.");
        }

        public void OrchestratorLead()
        {
            Console.WriteLine("\nAll the musicians together create wonderful and classical music that the audiance loves.");
        }
    }

    class Program
    {
        static void Main()
        {
            Orhestrator orch = new Orhestrator();
            Orhestrator musical = new Orhestrator();

            orch.Violinist();
            orch.Flutistist();
            orch.Pianist();

            musical.OrchestratorLead();

            Console.ReadKey();
        }
    }
}
