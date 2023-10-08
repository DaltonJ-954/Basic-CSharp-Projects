using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Parameters
{
    class Employee<T>
    {
        Employee<T> food = new Employee<T>();
        List<string> fruits = new List<string> { "apple", "cherry", "grape", "plum"};

        Employee<T> employee1 = new Employee<T>();
        List<int> numbers = new List<int> { 6, 12, 3, 44 };
    }
}