using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    class ReverseNumber
    {
        public void Reverse()
        {
            // Get the number to be reversed
            Console.WriteLine("Enter the number to be reversed: ");
            string input = Console.ReadLine();
            double numberOfDigits = input.Length;
            int normalNumber = Convert.ToInt32(input);
            Console.WriteLine($"Number before reversal is {normalNumber}");
            // define variables
            int reverseNumber = 0;
            for (int i=1; i<= numberOfDigits; i++)
            {
                reverseNumber += ((normalNumber) - (normalNumber / 10)*10) * (Convert.ToInt32(Math.Pow(10, numberOfDigits - i)));
                normalNumber /= 10;
            }
            Console.WriteLine($"Number after reversal is {reverseNumber}");
        }
    }
}
