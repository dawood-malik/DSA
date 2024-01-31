using System;
namespace coding
{
    class Prgram
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }; int k = 2;
            //Output: 6
            int max_count = 0;
            int left = 0;
            for(int right = 0; right < nums.Length; right++)
            {
                k += nums[right] == 0 ? -1 : 0;
                if (k < 0)
                {
                    k += nums[left] == 0 ? 1 : 0;
                    left++;
                }
                else
                {
                    max_count = Math.Max(max_count, right - left+1);
                }
            }
            Console.WriteLine(max_count);
        }
    }
}