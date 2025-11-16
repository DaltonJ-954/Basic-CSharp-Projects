using System;

namespace OverLoadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Smoothie drink = new Smoothie();

            Console.WriteLine(drink.ToString().Contains(""));
        }
    }
    class Smoothie
    {
        public string Milk { get; set; }
        public string Banana { get; set; }
        public string Strawberries { get; set; }
        public string Coconut { get; set; }
        public string Oatmeal { get; set; }

        public Smoothie()
        {
        }

        public void myFav(string strawberries, string banana, string milk, string oatmeal)
        {
            Console.WriteLine($"My fave smoothie is made with {banana}, {strawberries}, and {milk}, plus whipped topping, and {oatmeal} on top.");
        }
    }
}
