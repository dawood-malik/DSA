using System;
using System.Collections.Generic;

namespace kuu
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "the sky is blue";
            //Output:"blue is sky the"

            int len = s.Length;
            List<string> list = new List<string>();
            int min = int.MaxValue;
            int left = 0;
            string ans = "";

            while (left < len)
            {
                if (s[left] == ' ')
                {
                    left++;
                    continue;
                }

                if ((s[left] >= 'a' && s[left] <= 'z') || (s[left]>='A' && s[left]<='Z')
                {
                    string sample = "";
                    min = left;
                    int val = min;
                    while (val < len && s[val] != ' ')
                    {
                        val++;
                    }
                    sample += s.Substring(min, val - min);
                    list.Add(sample);
                    left = val; // Move the left index to the next word's starting position
                }
                else
                {
                    left++;
                }
            }
            string[] strings =list.ToArray();
            list.Clear();
            for (int i = strings.Length - 1; i >= 0; i--)
            {
                list.Add(strings[i]);
            }

            strings=list.ToArray();
            string helper = string.Join(' ', strings);
            Console.WriteLine(helper);

            
           
        }
    }
}
