using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    class PerfectNumber
    {
        // initialize variables
        int testCount = 0;
        public void IsPerfect()
        {
            // get the number from user
            Console.WriteLine("Enter a number to check is perfect or not:");
            int number = Convert.ToInt32(Console.ReadLine());
            string linePrint = "";

            for (int i =1; i<number; i++)
            {
                if (number % i == 0)
                {
                    testCount += i;
                    linePrint += $"{i} + ";
                }
            }
            if (number == testCount)
            {
                Console.WriteLine($"{number} is a perfect number");
                Console.WriteLine($"{number} = {linePrint.Substring(0,linePrint.Length-2)}");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number");
            }
        }
    }
}
