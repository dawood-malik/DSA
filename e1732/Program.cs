using System;
using System.Globalization;

namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gain = { -5, 1, 5, 0, -7};
            int[] altitude = new int[gain.Length+1];
            altitude[0] = 0;
            int temp = 0;
            int max = int.MinValue;
            max = Math.Max(altitude[0], max);
            for (int i = 0; i < gain.Length; i++)
            {
                temp = altitude[i];
                altitude[i + 1] = gain[i] + temp;
                max = Math.Max(altitude[i+1], max); 
            }
            Console.Write(max);
            
        }
    }
}