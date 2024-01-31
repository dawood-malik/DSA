using System;
namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3 }, nums2 = { 2, 4, 6 };
            IList<IList<int>> list = new List<IList<int>>();
            //Output: [[1,3],[4,6]]
            IList<int> nums1_=new List<int>();  
            IList<int> nums2_=new List<int>();
            foreach(var x in nums1)
            {
                if (!nums2.Contains(x))
                {
                    nums1_.Add(x);
                }
            }
            foreach(var x in nums2)
            {
                if (!nums1.Contains(x))
                {
                    nums2_.Add(x);
                }
            }
            list.Add(nums1_);
            list.Add(nums2_);
        }
    }
}