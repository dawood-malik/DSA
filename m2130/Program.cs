using System;
using System.CodeDom.Compiler;
using System.Globalization;

namespace kuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            List<List<int>> list = Subsets(nums);

            foreach(var x in list)
            {
                Console.WriteLine(x);
            }
        }
        public static List<List<int>> Subsets(int[] nums)
        {
            List<List<int>> result=new List<List<int>>();
            GenerateSubsets(nums, 0, new List<int>(), result);
            return result;
        }

        public static void GenerateSubsets(int[] nums,int index,List<int> helper,List<List<int>> result)
        {
            result.Add(new List<int>(helper));
            for(int i=index; i<nums.Length; i++)
            {
                helper.Add(nums[i]);
                GenerateSubsets(nums, index + 1, helper, result);
                helper.RemoveAt(helper.Count - 1);
            }
        }
    }
}