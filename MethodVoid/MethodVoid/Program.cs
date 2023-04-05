using System;

namespace MethodVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleVoid intNum = new ExampleVoid();
            intNum.intMethod();


            try
            {
                Console.WriteLine("Please enter a number: ");
                int split = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(split / 2);
            }
            catch
            {
                return;
            }
            Console.ReadKey();

            OverLoad loader = new OverLoad();

            loader.overLoadInt(34);
            loader.overLoadStr("Tech");
            loader.overLoadCombo(2023, "Academy");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

