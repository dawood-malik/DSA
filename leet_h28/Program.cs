using System;
using System.Net.Http.Headers;

namespace kuuu
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data=0, Node next=null)
        {
            this.data = data;
            this.next = next;
        }
    }
        class MergeList
    {
        public Node MergeKLists(Node[] lists)
        {
            List<int> merger=new List<int>();
            foreach(var list in lists)
            {
                Node current = list;
                while (current != null)
                {
                    merger.Add(current.data);
                    current = current.next;
                }
            }
            merger.Sort();
            Node helper = new Node();
            Node dummy = helper;
            foreach(var item in merger)
            {
                dummy.next = new Node(item);
                dummy=dummy.next;
            }
            return helper.next;
        }
  
    }

    class Program 
    { 
        static void Main(string[] args)
        {
            Node[] lists = new Node[] 
            { 
                new Node(1,new Node(4,new Node (2))),new Node(10,new Node(3,new Node (5)))
            };
            MergeList merger=new MergeList();
            Node head=merger.MergeKLists(lists);
            while (head != null)
            {
                Console.Write(head.data + "-->");
                head = head.next;
            }

        }
    }

}