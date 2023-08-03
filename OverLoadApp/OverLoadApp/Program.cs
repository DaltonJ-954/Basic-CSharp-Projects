using System;

namespace OverLoadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Smoothie smoothie = new Smoothie("Frozen", "coconut chips", "almond milk", "ripe banana", "maple");
        }
    }
    class Smoothie
    {
        string milk;
        string banana;
        string strawberries;
        string coconut;
        string oatmeal;

        public Smoothie(string coconut, string milk, string banana)
        {
            this.coconut = coconut;
            this.milk = milk;
            this.banana = banana;
        }
        public Smoothie(string oatmeal, string coconut, string milk, string banana)
        {
            this.coconut = coconut;
            this.milk = milk;
            this.banana = banana;
            this.oatmeal = oatmeal;
        }
        public Smoothie(string oatmeal, string coconut, string strawberries, string milk, string banana)
        {
            this.strawberries = strawberries;
            this.coconut = coconut;
            this.milk = milk;
            this.banana = banana;
            this.oatmeal = oatmeal;
        }
    }
}
