using System;
namespace kuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            //Output: 49
            int MaxArea = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int h = Math.Min(height[left], height[right]);
                int breadth = right - left;
                MaxArea=Math.Max(MaxArea,h*breadth);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            Console.WriteLine(MaxArea);
            
        }
    }
}