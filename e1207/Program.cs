/*
// Sample code to perform I/O:

name = Console.ReadLine();                  // Reading input from STDIN
Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT

// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
*/

// Write your code here
using System;
namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] members = new int[N];

            for (int i = 0; i < N; i++)
            {
                members[i] = int.Parse(Console.ReadLine());
            }
            int E = int.Parse(Console.ReadLine());
            string[] graph = new string[E];
            for (int i = 0; i < E; i++)
            {
                string dummy = "";
                string[] num = Console.ReadLine().Split();
                dummy = num[0] + num[1];
                graph[i] = dummy;
            }

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            string helper = A.ToString() + B.ToString();
            bool flag = false;
            foreach (var x in graph)
            {
                if (x == helper)
                {
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }






        }
    }

}