using System;
using System.Diagnostics.Metrics;

namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aeiou"; int k = 2;
            //Output: 3
            int vowelInWindow = 0;
            int max = 0;
            string vowels = "aeiouAEIOU";
            for (int i = 0; i< k; i++) 
            {
                if (vowels.Contains(s[i]))
                {
                    vowelInWindow++;
                }
            }
            max=vowelInWindow;

            for(int i=k; i < s.Length; i++)
            {
                if(vowels.Contains(s[i-k]))
                {
                    vowelInWindow--;
                }
                if (vowels.Contains(s[i]))
                {
                    vowelInWindow++;
                }
                if (vowelInWindow > max)
                {
                    max = vowelInWindow;
                }
            }
            Console.WriteLine(max);
        }
    }
}