using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        class Calculator
        {
            // Private field to store the internal result (protected from direct access)
            private int result = 0;

            // Public methods to interact with the Calculator object
            public void Add(int value)
            {
                result += value;
            }

            public void Subtract(int value)
            {
                result -= value;
            }

            public int GetResult()
            {
                return result;
            }
        }


        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            myCalculator.Add(5);      // Add 5 to the result
            myCalculator.Subtract(2);  // Subtract 2 from the result
            int finalResult = myCalculator.GetResult();  // Retrieve the final result (3)
        }
    }
}
