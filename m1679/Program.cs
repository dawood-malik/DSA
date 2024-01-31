using System;
namespace kuu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 }; int k = 5;
            //Output: 2
            List<int> list = new List<int>(nums);
            Array.Clear(nums);
            list.Sort();
            nums =list.ToArray();

            
            int i = 0;
            int j = nums.Length-1;
            int count = 0;

            while (i <= j)
            {
                int sum = 0;
                sum = nums[i] + nums[j];
                if (sum < k)
                {
                    i++;
                }
                else if (sum > k)
                {
                    j--;
                }
                else
                {
                    list.Remove(nums[i]);
                    list.Remove(nums[j]);
                    i++;
                    j--;
                    count++;
                }
            }
            
            
        }
    }
}