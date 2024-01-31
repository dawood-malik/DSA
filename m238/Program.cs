using System;
namespace kuuu
{
    //Input: nums = [1,2,3,4]
    //Output: [24,12,8,6]
    class Program
    {
        static void Main(string[] args) 
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] product = new int[nums.Length];
            int num = 1;

            for(int i=0; i < nums.Length; i++)
            {
                product[i] = num;
                num *= nums[i];
            }
            num = 1;
            for(int i=nums.Length-1; i>=0; i--)
            {
                product[i] *= num;
                num *= nums[i];
            }
            foreach(var val in product)
            {
                Console.WriteLine(val);
            }
        }
    }

}