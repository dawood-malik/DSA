using System;
using System.Diagnostics;

namespace kuu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            //Output: 5
            int left = 0;
            int right = prices.Length-1;
            int maxval = 0;

            while (left < right)
            {
                int val = prices[right] - prices[left];
                Console.WriteLine(val);
                maxval = Math.Max(maxval, val);
                if (prices[left] < prices[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            Console.WriteLine(maxval);
        }
    }
}