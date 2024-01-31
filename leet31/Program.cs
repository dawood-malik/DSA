using System;
using System.Security.Cryptography;

namespace kuuu 
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;
            IList<IList<int>> list = combinationSum(candidates, target);
            foreach(var val in list)
            {
                foreach(var item in val)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
        }

        public static IList<IList<int>> combinationSum(int[] candidates, int target)
        {
            IList<IList<int>> list=new List<IList<int>>();
            Array.Sort(candidates);
            Backtracking(candidates, target,list,new List<int>(),0,0);
            return list;
        }
        public static void Backtracking(int[] candidates, int target, IList<IList<int>> list,List<int> helper,int start,int sum)
        {
            if (sum == target)
            {
                list.Add(new List<int>(helper));
                return;
            }
            if (sum > target)
            {
                return;
            }
            for(int i=start;i<candidates.Length;i++)
            {
                //if (sum+candidates[i] > target) break;
                if (i > start && candidates[i] == candidates[i - 1] ) continue;

                
                sum += candidates[i];
                helper.Add(candidates[i]);
                Backtracking(candidates, target, list, helper, i + 1,sum) ;
                
                sum -= candidates[i];
                helper.RemoveAt(helper.Count-1);
                
            }
        }
    }

}
