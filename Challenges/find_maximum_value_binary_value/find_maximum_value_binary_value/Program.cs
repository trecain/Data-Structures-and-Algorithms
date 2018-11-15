using System;
using Lab15_Trees.Classes;

namespace find_maximum_value_binary_value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coding Challenge: Find The Maximum Value Of A Binary Tree");

            Node root = new Node(3);
            root.LeftChild = new Node(8);
            root.RightChild = new Node(7);

            root.LeftChild.LeftChild = new Node(2);
            root.LeftChild.RightChild = new Node(9);
            root.LeftChild.RightChild.LeftChild = new Node(5);
            root.LeftChild.RightChild.RightChild = new Node(12);
            root.RightChild.RightChild = new Node(9);
            root.RightChild.RightChild.LeftChild = new Node(4);
            Console.WriteLine($"Max Value: {FindMaxValue(new BinaryTree(root))}");
        }

        public static int FindMaxValue(BinaryTree tree, Node node = null)
        {
            if (tree != null)
                node = tree.Root;

            int max = int.MinValue;

            if (node != null)
            {
                int left = FindMaxValue(null, node.LeftChild);
                int right = FindMaxValue(null, node.RightChild);
                if (left > right)
                    max = left;
                else
                    max = right;

                if ((int)node.Data > max)
                    max = (int)node.Data;
            }
            return max;
        }
    }
}
