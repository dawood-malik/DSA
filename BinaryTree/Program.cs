using System;

namespace Leo
{
    class BinaryNode
    {
        public int data;
        public BinaryNode left;
        public BinaryNode right;
    }

    class BinaryTree
    {
        public BinaryNode root = new BinaryNode();
        public BinaryTree()
        {
            root = null;
        }
        public void AddNode(int data)
        {
            root = AddRecursive(root, data);
        }
        public BinaryNode AddRecursive(BinaryNode node, int data)
        {
            if (node == null)
            {
                node = new BinaryNode();
                node.data = data;
            }
            else if (data < node.data)
            {
                node.left = AddRecursive(node.left, data);
            }
            else if (data > node.data)
            {
                node.right = AddRecursive(node.right, data);
            }

            return node;
        }
        public void preOrderTraversal(BinaryNode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.data);
                preOrderTraversal(node.left);
                preOrderTraversal(node.right);
            }

        }


    }



    class Program
    {

        public static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.AddNode(5);
            binaryTree.AddNode(3);
            binaryTree.AddNode(7);
            binaryTree.AddNode(1);
            binaryTree.AddNode(4);
            binaryTree.AddNode(6);
            binaryTree.AddNode(8);

            binaryTree.preOrderTraversal(binaryTree.root);


        }

    }

}
