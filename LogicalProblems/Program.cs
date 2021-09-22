using System;

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
                Console.WriteLine("\nEnter any key otherthan number from 1 to 6, to exit program\n or");
                Console.WriteLine("To run program, Select and enter Program number between 1 and 6: \n" +
                    "(1. Fibonacci series, 2. Perfect number, 3. Prime number\n" +
                    "4. Reverse a number, 5. Coupan number, 6. Stop watch)\n");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 1:
                        new FibonacciSeries().Print(10);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
