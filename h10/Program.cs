using System;
namespace kuu 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            int n = nums.Length - 1;
            int index = -1;

            for(int i=n-2;i>=0;i--)
            {
                if (nums[i] < nums[i + 1])  //2<3 index=1;
                {
                    index = i;
                    break;
                }
            }
            if(index == -1)
            {
                Array.Reverse(nums);
                return;
            }

            for(int i = n - 1; i > index; i++)
            {
                if (nums[i] > nums[index])
                {
                    int temp = nums[i];
                    nums[i] = nums[index];
                    nums[index] = temp;
                    break;
                }
            }
            Array.Sort(nums, index + 1, n - 1 - index);
        }
    }

}
