using System;
using System.Runtime.InteropServices;

namespace kuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int i = 0;
            int res = 0;
            
            while(i < chars.Length)
            {
                int add = 1;
                while (i+add<chars.Length && chars[i + add] == chars[i])
                {
                    add++;
                }
                chars[res] = chars[i];
                res++;

                if (add > 1)
                {
                    foreach(var val in add.ToString().ToCharArray())
                    {
                        chars[res]=val;
                        res++;
                    }
                }
                i += add; 
            }
            for(int j= 0;j< res; j++)
            {
                Console.WriteLine(chars[j]);    
            }
        }
    }
}