using System;
using System.Text;

namespace Kuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            string helper = "aeiouAEIOU";
            Stack<char> stack = new Stack<char>();
            StringBuilder sb = new StringBuilder();
            foreach(var k in str)
            {
                if (helper.Contains(k))
                {
                    stack.Push(k);
                }
            }
            foreach(var k in str)
            {
                if(helper.Contains(k))
                {
                    sb.Append(stack.Pop()); 
                }
                else
                {
                    sb.Append(k);
                }
            }
            Console.WriteLine(sb.ToString());
                
        }
    }
}