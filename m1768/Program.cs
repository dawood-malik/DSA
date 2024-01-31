// See https://aka.ms/new-console-template for more information
using System;
namespace kuuu
{
    class Program 
    { 
        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqrst";
            int left = 0;
            int i = 0;
            int j = 0;
            int len=word1.Length+word2.Length-1;

            while (left<=len)
            {
                if (i < word1.Length)
                {
                    Console.Write(word1[i]);
                    i++;
                }
                if(j< word2.Length)
                {
                    Console.Write(word2[j]);
                    j++;
                }
                left++;
            }
        }
    }

}
