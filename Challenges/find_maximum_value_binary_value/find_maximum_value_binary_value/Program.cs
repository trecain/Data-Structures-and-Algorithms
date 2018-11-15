using System;
using Lab15_Trees.Classes;

namespace find_maximum_value_binary_value
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Coding Challenge: Find The Maximum Value Of A Binary Tree");

            ///<summary>
            /// creates the root node and adds nodes to the binary tree
            /// </summary>
            Node root = new Node(3);
            root.LeftChild = new Node(8);
            root.RightChild = new Node(7);

            root.LeftChild.LeftChild = new Node(2);
            root.LeftChild.RightChild = new Node(9);
            root.LeftChild.RightChild.LeftChild = new Node(5);
            root.LeftChild.RightChild.RightChild = new Node(12);
            root.RightChild.RightChild = new Node(9);
            root.RightChild.RightChild.LeftChild = new Node(4);
            /// runs the findmaxvalue method on the root node of the binary tree
            Console.WriteLine($"Max Value: {FindMaxValue(new BinaryTree(root))}");
        }


        /// <summary>
        /// finds the maximum value in a binary tree
        /// </summary>
        /// <param name="tree">binary tree to traverse through to get value</param>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int FindMaxValue(BinaryTree tree, Node node = null)
        {
            // checks to see if the tree is null
            if (tree != null)
                node = tree.Root;

            int max = int.MinValue;
            
            ///checks if node is not null
            if (node != null)
            {
                // recursively to compare nodes on the tree
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
