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

    static class OverLoad // This class is used to demonstrate the overload method as well as declaring it to be static.
    {
        public void overLoadInt(int sum1) // The method passes off as a integer parameter
        {
            return;
        }

        public void overLoadStr(string okay) // The method passes off as a string parameter
        {
            return;
        }

        public void overLoadCombo(int sum2, string okay) // The method passes off an integer and string parameter
        {
            return; // In C#, a method can return any type of data including objects. In other words, methods are allowed to return objects without any compile time error.
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

