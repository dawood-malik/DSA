using System;

namespace kuuu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[]{1, 2, 3},
                new int[]{4, 5, 6},
                new int[]{7, 8, 9}
            };

            IList<int> list= new List<int>();
            int row = matrix.Length;
            int col = matrix[0].Length;
            int left = 0, right = col - 1;
            int top = 0, bottom = row - 1;

            while(left<=right && top<=bottom)
            {
                for(int i=left; i<=right; i++)
                {
                    list.Add(matrix[top][i]);
                }
                top++;

                for(int i= top; i <= bottom; i++)
                {
                    list.Add(matrix[i][right]);
                }
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        list.Add(matrix[bottom][i]);
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        list.Add(matrix[i][left]);
                    }
                    left++;
                }
                
            }
            foreach(var val in list)
            {
                Console.WriteLine(val);
            }
        }
    }
}
