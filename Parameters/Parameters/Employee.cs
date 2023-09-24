using System;
using System.Collections.Generic;
using System.Text;

namespace Parameters
{
    class Employee<T>
    {
        public string[] things { get; set; }

        Employee<T> employee = new Employee<T>();
        List<string> fruits = new List<string> { "apple", "cherry", "grape", "plum"};

        Employee<T> employee1 = new Employee<T>();
        List<int> numbers = new List<int> { 6, 12, 3, 44 };
    }
}