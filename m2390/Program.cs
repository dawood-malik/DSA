using System;
using System.Text;

namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "leet**cod*e";
            var newstring = new StringBuilder();
            
            for(int i=0;i<s.Length; i++)
            {
                if (s[i] == '*')
                {
                    newstring.Length--;
                }
                else
                {
                    newstring.Append(s[i]);
                }
            }
            Console.WriteLine(newstring.ToString());
        }
    }
}