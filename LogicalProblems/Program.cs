﻿using System;

namespace LogicalProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            bool isRun = true;
            while (isRun)
            {
                // Select the Program number to run or to exit
                Console.WriteLine("\n\nEnter any key otherthan number from 1 to 6, to exit program\n or");
                Console.WriteLine("To run program, Select and enter Program number between 1 and 6: \n" +
                    "(1. Fibonacci series, 2. Perfect number, 3. Prime number\n" +
                    "4. Reverse a number, 5. Coupan number, 6. Stop watch)\n");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 1:
                        // get number n, from user, to print first n numbers in series
                        Console.WriteLine("Howmany numbers should be there in series?: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        new FibonacciSeries().Print(n);
                        break;
                    case 2:
                        new PerfectNumber().IsPerfect();
                        break;
                    case 3:
                        // get the number from user
                        Console.WriteLine("Enter a number to check is prime or not:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        bool isPrime = new PrimeNumber().IsPrime(number);
                        if (isPrime == true)
                            Console.Write($"{number} is a prime number");
                        else
                            Console.Write($"{number} is not a prime number");
                        break;
                    case 4:
                        new ReverseNumber().Reverse();
                        break;
                    case 5:
                        new CouponNumbers().CountRandom();
                        break;
                    case 6:
                        new StopWatch().Measure();
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
