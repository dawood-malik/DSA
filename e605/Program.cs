using System;
namespace kuu
{
    class Program 
    { 
        static void Main(string[] args)
        {
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            int n = 2;
            //Output: true
            int k=flowerbed.Length;

            int count = 0;

            for (int i = 0; i < k; i++)
            {
                if (flowerbed[i] == 0 && ( i == 0 || flowerbed[i - 1] == 0) &&( i == k - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    count++;
                }
                
            }
            bool check = count >= n;
            Console.WriteLine(check);
        }
    }

}