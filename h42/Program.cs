using System;
namespace Kuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
            //Output: 6
            int leftmax = 0, rightmax = 0;
            int left = 0, right = height.Length-1;
            int area = 0;
            while(left< right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >leftmax)
                    {
                        leftmax = height[left];
                    }
                    else
                    {
                        area += leftmax - height[left];

                    }
                    left++;
                }
                else
                {
                    if (height[right]>rightmax)
                    {
                        rightmax = height[right];
                    }
                    else
                    {
                        area += rightmax - height[right];
                    }
                    right--;
                }
            }
            Console.WriteLine(area);
        }
    }
}