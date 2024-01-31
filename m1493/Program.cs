﻿using System;
namespace coding 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 1, 1, 0, 1, 1, 0, 1 };
            //Output: 5
            //int right = 0;
            int k = 1;
            int left = 0;
            int max_count = 0;
            for(int right=0;right<nums.Length;right++)
            {
                k += nums[right] == 0 ? -1 : 0;
                if (k < 0)
                {
                    k += nums[left] == 0 ? 1 : 0;
                    left++;
                }
                else
                {
                    max_count = Math.Max(max_count, right - left );
                }
            }
            Console.WriteLine(max_count);
        }
    }


}
