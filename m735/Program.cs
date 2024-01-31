using System;
namespace kuu
{
    class Program 
    { 
        static void Main(string[] args)
        {
            string[] ops = { "5", "-2", "4", "C", "D","9","+","+" };
            
            List<int> list=new List<int>();
            for(int i=0;i<ops.Length; i++)
            {
                if (ops[i] !="C" && ops[i]!="D" && ops[i]!="+")
                { 
                    int val = int.Parse(ops[i]);    
                    list.Add(val);
                }
                else if (ops[i] == "C")
                {
                    int listsize1 = list.Count;
                    
                    list.RemoveAt(listsize1-1);

                }
                else if (ops[i]=="D")
                {
                    int listsize2=list.Count;
                    int val2 = list[listsize2 - 1]*2;
                    list.Add(val2);
                }
                else if (ops[i]=="+")
                {
                    int listsize3=list.Count;
                    int val3 = list[listsize3 - 2] + list[listsize3 - 1];
                    list.Add(val3);
                }
            }
            foreach(var x in list)
            {
                Console.WriteLine(x);
            }
            
            
            

        }
    }

}
