using System;

namespace MethodVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleVoid intNum = new ExampleVoid();
            Console.WriteLine("Input a number that will be divided 2: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            intNum.intMethod(num1);


            try
            {
                
            }
            catch
            {
                return;
            }
            Console.ReadKey();


            OverLoad.staticoverLoadInt(34);
            OverLoad.overLoadStr("Tech");
            OverLoad.overLoadCombo(2023,"Academy");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

