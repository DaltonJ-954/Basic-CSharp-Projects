using System;
using System.Collections.Generic;
using System.Text;

namespace MethodVoid
{
    class ExampleVoid
    {
        public void intMethod() // A class method
        {
            int num1 = 43; // A variable being declared as an integer
            Console.WriteLine(num1 / 2); // Console WriteLine outputting the operation value
        }

        public void Addition(out int box) // Method with output parameters
        {
            box = 30;
            box += box;
        }
    }

    static class OverLoad // This class is used to demonstrate the overload method.
    {
        public static void staticoverLoadInt(int sum1) // The method passes off as a integer parameter
        {
            Console.WriteLine(sum1);
        }

        public static void overLoadStr(string okay) // The method passes off as a string parameter
        {
            Console.WriteLine("Tech");
        }

        public static void overLoadCombo(int sum2, string okay) // The method passes off an integer and string parameter
        {
            Console.WriteLine(sum2 + " " + okay); // In C#, a method can return any type of data including objects.
        }
    }

    //static class Person
    //{
    //    // Fields
    //    private string name;
    //    private int age;

    //    // Constructor
    //    public Person(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }
    //}

}

