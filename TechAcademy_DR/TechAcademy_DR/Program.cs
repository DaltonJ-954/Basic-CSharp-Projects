﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademy_DR
{
    class Program
    {
        static void Main()
        {
            // The WriteLine method writes the items of a list to the file
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            // The ReadLine method returns one line from the file.
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("What page number?");
            // Strings are used for storing text.
            int page = Convert.ToInt32(Console.ReadLine());
            // An int(integer) is a variable that must be a specified data type
            

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.");
            //  Boolean type is declared with the bool keyword and can only take the values true or false
            bool help = Convert.ToBoolean(Console.ReadLine());

            string experience = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            Console.ReadLine();

            string feedback = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please give specifics");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.\nHave a great day!");
            Console.ReadLine();
        }
    }
}
