using System;
namespace kuuu
{
    class Program 
    {
        //Input: nums = [1,1,1,2,2,3], k = 2
        //Output: [1,2]
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach(var num in nums)
            {
                if (!map.ContainsKey(num))
                {
                    map.Add(num, 0);
                }
                map[num]++;
            }
            var sorted_dict=map.OrderByDescending(x=>x.Value).ToList();
            IList<int> list = new List<int>();
            foreach(var num in sorted_dict)
            {
                Console.WriteLine(num.Key+"="+num.Value);
            }
            
            
        }   

    }

}