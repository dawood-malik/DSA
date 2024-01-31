using System;
namespace kuu
{
    class Program 
    {
        static void Main(string[] args)
        {
            string senate = "RD";
            Queue<char> queue = new Queue<char>(senate);
            int countR = senate.Count(x => x == 'R');
            int countD = senate.Length - countR;
            int scale = 0;
            while(countD > 0 && countR>0)
            {
                char senator=queue.Dequeue();
                if (senator == 'R')
                {
                    if (scale >= 0)
                    {
                        countD--;
                        queue.Enqueue(senator);
                    }
                    scale++;
                }
                else
                {
                    if(scale >= 0)
                    {
                        countR--;
                        queue.Enqueue(senator);
                    }
                    scale--;
                }
            }

        }
        

    }

}