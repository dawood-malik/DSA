using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace coding
{

    class DynamicArray
    {
        public int[] array;
        public int capacity;
        public int size;
        public DynamicArray(int capacity)
        {
            this.array = new int[capacity];
            this.capacity = capacity;
            this.size = 0;
        }
        //I will take i for index and n for value
        public void AddElement(int n)
        {
            if (size == capacity)
            {
                resize();
            }
            array[size] = n;
            size++;
        }
        private void resize()
        {
            int newcapacity = capacity * 2;
            int[] newarray = new int[newcapacity]; //this is empty array with size double the previous size
            Array.Copy(array, newarray, size);
            array = newarray;
            capacity = newcapacity;

        }
        public int getSize()
        {
            return size;
        }
        public int getCapacity()
        {
            return capacity;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray dynamic = null;
            List<object> output = new List<object>();
            var input = new List<object> { "Array", 1, "AddElement", 1, "getSize" };
			foreach(var item in input)
            {
                switch (item)
                {
                    case "Array":
                        int nextele = input.IndexOf(item) + 1;
                        if (nextele < input.Count && input[nextele] is int value)
                        {
                            dynamic = new DynamicArray(value);
                            output.Add("null");
                        }
                        break;
                    case "AddElement":
                        int nextelement = input.IndexOf(item) + 1;
                        if (nextelement < input.Count && input[nextelement] is int value2)
                        {
                            dynamic.AddElement(value2);
                            output.Add("null");
                        }
                        break;
                    case "getSize":
                        int val = dynamic.getSize();

                        output.Add(val);
                        break;
                }
            }
            foreach (var item in output)
            {
                Console.Write(item+" ");
            }
        }
    }

}
