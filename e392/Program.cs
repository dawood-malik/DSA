using System;
using System.ComponentModel.DataAnnotations;

namespace kuu
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "acb";
            string t = "ahbgdc";
            int i = 0;
            int j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            Console.WriteLine(i == s.Length);


        }
    }
}