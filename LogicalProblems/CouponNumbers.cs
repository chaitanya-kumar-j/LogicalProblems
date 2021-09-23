using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalProblems
{
    class CouponNumbers
    {
        // define variables
        int individualCount = 1, overallCount = 0;
        public void CountRandom()
        {
            // get coupon numbers
            Console.WriteLine("Enter the number of coupons to be generated");
            int numberOfCoupons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of digits to be in each coupon:");
            int numberOfDigits = Convert.ToInt32(Console.ReadLine());
            int[] couponsList = new int[numberOfCoupons+1];
            // random number generator
            Random random = new Random();
            for(int i = 1; i <= numberOfCoupons; i++)
            {
                overallCount++;
                int a = Convert.ToInt32(Math.Pow(10, numberOfDigits - 1));
                int b = Convert.ToInt32(Math.Pow(10, numberOfDigits));
                int randomCoupon = random.Next(a,b);
                if (couponsList.Contains(randomCoupon))
                {
                    i--;
                    individualCount += 1;
                }
                else
                {
                    couponsList[i] = randomCoupon;
                    Console.WriteLine($"Number of random numbers generated to get Coupon number {i} are {individualCount}");
                    individualCount = 1;
                }
            }
            Console.WriteLine($"Number of random numbers generated to get {numberOfCoupons} Coupons are {overallCount}");
        }
        
    }
}
