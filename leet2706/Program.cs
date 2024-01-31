using System;
using System.Data.SqlTypes;

namespace kuuuu
{
    //Input: prices = [1,2,2], money = 3
    //Output: 0
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 1, 2, 2 };
            Array.Sort(prices);
            int money = 3;
            int count = 0;
            
            foreach (int item in prices)
            {
                if (money >= item)
                {
                    money -= item;
                    count++;
                }
                else
                {
                    break;
                }
            }
            if(count ==2 && money>=0)
            {
                Console.WriteLine("Solution exists");
            }

        }
    }

}
