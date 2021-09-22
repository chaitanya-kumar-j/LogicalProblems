using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    class FibonacciSeries
    {
        public void Print(int n)
        {
            // define variables
            int firstNumber=0, secondNumber = 1, nextNumber;
            Console.WriteLine($"First {n} numbers of fibinacci series are: ");
            for (int i=1; i<=n; i++)
            {
                nextNumber = firstNumber + secondNumber;
                Console.Write($"{firstNumber} ");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
    }
}
