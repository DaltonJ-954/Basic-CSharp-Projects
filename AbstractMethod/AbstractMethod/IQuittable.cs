using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethod
{
    interface IQuittable
    {
        public void Quit()
        {
            var input = Console.ReadKey().Key;
            if(input == ConsoleKey.Q)
            {
                Console.WriteLine("\nEnd program...");
            }
        }
    }
}
