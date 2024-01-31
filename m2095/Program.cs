using System;
using System.ComponentModel.Design;

namespace kuuu
{
    class Node
    {
        public int data;
        public Node next;
    }
    class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void AddNode(int data)
        {
            Node temp = head;
            Node newNode = new Node();
            newNode.data = data;
            if(temp == null)
            {
                head = newNode;
            }
            else
            {
                while (temp.next!= null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            
        }
        public void EvenOdd()
        {
            if(head==null && head.next==null)
            {
                return;
            }
            Node even= head.next;
            Node odd = head;
            Node evenhead = even;
            while(even!=null && even.next != null)
            {
                odd.next = even.next;
                odd=odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenhead;
            
        }
        public void PrintList()
        {
            Node flag = head;
            while (flag!= null)
            {
                Console.Write(flag.data+" ");
                flag=flag.next;
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] head = { 1, 3, 4, 7, 1, 2, 6 };
            //[1,3,4,1,2,6]
            LinkedList list= new LinkedList();
            foreach(int i in head)
            {
                list.AddNode(i);
            }
            list.PrintList();
            
            list.EvenOdd();
            list.PrintList();

        }
    }
}