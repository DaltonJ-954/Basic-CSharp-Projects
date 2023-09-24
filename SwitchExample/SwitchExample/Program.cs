using System;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string history = "September 14th";

            switch (history)
            {
                case "December 25th":
                    Console.WriteLine("Is the day we celebrate the holiday.");
                    break;
                case "August 8th":
                    Console.WriteLine("On August 8th, the KKK marches in Washington D.C..");
                    break;
                case "May 9th":
                    Console.WriteLine("The Birth Control Pill Is Approved .");
                    break;
                case "April 4th":
                    Console.WriteLine("Bill Gates and Paul Allen founded Microsoft at a time where most Americans used typwriters.");
                    break;
                case "September 11th":
                    Console.WriteLine("What a tragic day it was. The country mourned nation wide.");
                    break;
                case "November 22nd":
                    Console.WriteLine("John F. Kennedy was murdered while riding in a presidential motorcade in Dallas, Texas.");
                    break;
                case "August 29th":
                    Console.WriteLine("The Turbo Graphics 16 was the first console marketed in the fourth generation, commonly known as the 16-bit era, though the console has an 8-bit central processing unit (CPU) coupled with a 16-bit graphics processor 3.");
                    break;
                case "April 1st":
                    Console.WriteLine("Stephen G. Wozniak and Steve Jobs founded Apple together where their first model was built in Steve's garage.");
                    break;
                case "September 29th":
                    Console.WriteLine("CERN, the European Organization for Nuclear Research, was founded in 1954 by 12 countries in Western Europe.");
                    break;
                case "May 11th":
                    Console.WriteLine("At the young age of 36, Bob Marley passed away of cancer.");
                    break;
                case "September 14th":
                    Console.WriteLine("On September 14th, 2001, the Nintendo GameCube launched in Japan. It had launched with only 500,000 units.");
                    break;
                default:
                    Console.WriteLine("There are many historical events that happened all over the world.");
                    break;

                    Console.WriteLine();
                    Console.ReadKey();
            }
        }
    }
}