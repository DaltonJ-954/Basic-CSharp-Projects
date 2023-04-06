using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethod
{
    interface IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Quit method");
        }
    }
}
