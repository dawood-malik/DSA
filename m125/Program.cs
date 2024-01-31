using System;
namespace kuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            Array.Sort(nums);
            HashSet<List<int>> result=new HashSet<List<int>>();
           
            for(int i = 0; i < nums.Length-2; i++)
            {
                int left=i+1;
                int right = nums.Length - 1;
               
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    List<int> helper = new List<int>();

                    if (sum == 0)
                    {
                        helper.Add(nums[i]);
                        helper.Add(nums[left]);
                        helper.Add(nums[right]);
                        result.Add(new List<int>(helper));

                        while (left < right && nums[i] == nums[i - 1]) left++;
                        while(left<right && nums[i] == nums[i+1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum<0)
                    {
                        left++;
                    }
                    else if (sum > 0)
                    {
                        right--;
                    }
                }
                
            }
            foreach(var num in result)
            {
                foreach(var num2 in num)
                {
                    Console.Write(num2+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}