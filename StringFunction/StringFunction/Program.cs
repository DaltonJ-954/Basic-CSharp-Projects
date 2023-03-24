using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Dalton";
            //string quote = "The man said, \"Hello\", \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\scall";

            //int length = name.Length;

            //fileName = fileName.ToLower();

            //Console.WriteLine(fileName);
            //Console.ReadLine();


            //StringBuilder sb = new StringBuilder();

            //sb.Append("Hey Tech Academy");

            //Console.WriteLine(sb);
            //Console.ReadLine();

            //
            StringBuilder myStringBuilder = new StringBuilder("Hello World!");
            myStringBuilder.Append(" What a beautiful day.");
            Console.WriteLine(myStringBuilder);
            // The example displays the following output:
            //       Hello World! What a beautiful day.

            Console.ReadLine();
        }
    }
}
