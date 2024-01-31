using System;
namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 }; //o: 3
            int sum_left = 0;
            int sum_right = 0;
            foreach (int x in nums)
            {
                sum_right += x;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                sum_left += nums[i];
                if (sum_right == sum_left)
                {
                    Console.WriteLine(i);
                }
                sum_right -= nums[i];
            }
        }
    }
}