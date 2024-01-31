using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace kuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int first = int.MaxValue;
            int second = int.MaxValue;
            bool check = false;
            foreach(var num in nums)
            {
                if (num < first)
                {
                    first = num;
                }
                else if (num < second)
                {
                    second = num;
                }
                else
                {
                    check= true;
                }
            }
            Console.WriteLine(check);
            
            
            
                
        }
    }
}