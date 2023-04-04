using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
    class MathOp
    {
        // Methods are generally the block of codes or statements in a program that gives the user the ability to reuse and preserve memory.
        public int Mathmatical(int theNumber) // A method that is defined by an integer with an argument in the parentheses.
        {
            int result = theNumber * theNumber; // Integer the equals a math operation.
            return result; // The return function returns a value.
        }
        public int Mathmatical(decimal theLength) //
        {
            int area = Convert.ToInt32(34 * theLength); // An integer has been converted into user input

            return area;
        }

        public int Mathmatical(string car)
        {
            int word = Convert.ToInt32(car) + 9;
            return word;
        }
    }
}
