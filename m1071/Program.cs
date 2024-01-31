using System;
using System.Security.AccessControl;

namespace kuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "ABCDEF";
            string str2 = "ABC";
            int maxlength = 0;
            int index = 0;
            int actual = 0;
            int[,] dp=new int[str1.Length+1,str2.Length+1];

            for(int i=1; i<=str1.Length; i++)
            {
                for(int j=1; j<=str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = dp[i-1,j-1]+1;
                        if (dp[i, j] >= 1)
                        {
                            maxlength = dp[i, j];

                            
                        }
                        
                        
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }
            

        }
    
    }
}