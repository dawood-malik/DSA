using System;
using System.Runtime.InteropServices;

namespace kuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "1";
            int n = 5;
            string helper = "";

            if (n == 0)
            {
                helper = "";
            }
            
            for (int i=0;i < n;i++)
            {
                if (i == 0)
                {
                    helper = val;
                }
                else
                {
                    helper = formsequence(helper);
                    
                }   

            }
            Console.WriteLine(helper);
        }

        public static string formsequence(string val)
        {
            char[] chars= val.ToCharArray();
            string newseq = "";
            char current = chars[0];
            int count = 1;

            for(int i = 1; i < chars.Length; i++)
            {
                if (chars[i]==current)
                {
                    count++;
                }
                else
                {
                    newseq += count.ToString() + current;
                    count = 1;
                    current = chars[i];
                }
            }
            newseq += count.ToString() +current;

            return newseq;
        }
    }
}