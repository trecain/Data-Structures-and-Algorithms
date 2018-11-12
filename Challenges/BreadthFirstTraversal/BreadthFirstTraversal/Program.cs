using System;
using StackAndQueue.Classes;
using Lab15_Trees.Classes;
using Node = Lab15_Trees.Classes.Node;
using System.Collections.Generic;

namespace BreadthFirstTraversal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Coding Challenge: Breadth First Traversal ");
            Console.WriteLine(BreadthFirst(SampleTree()));
        }

        public static BinaryTree SampleTree()
        {
            Node root = new Node(2);
            BinaryTree tree = new BinaryTree(root);
            // LeftChildChild side
            Node firstLeftChild = new Node(7);
            root.LeftChild = firstLeftChild;

            Node secondLeftChild = new Node(2);
            firstLeftChild.LeftChild = secondLeftChild;

            Node firstLeftChildRight = new Node(6);
            firstLeftChild.RightChild = firstLeftChildRight;


            Node firstLeftChildRightLeftChild = new Node(5);
            firstLeftChildRight.LeftChild = firstLeftChildRightLeftChild;

            Node firstLeftChildRightRight = new Node(11);
            firstLeftChildRight.RightChild = firstLeftChildRightRight;


            // Right side
            Node firstRight = new Node(5);
            root.RightChild = firstRight;

            Node firstRightRight = new Node(9);
            firstRight.RightChild = firstRightRight;

            Node firstRightRightLeftChild = new Node(4);
            firstRightRight.LeftChild = firstRightRightLeftChild;

            return tree;
        }

        /// <summary>
        /// Breadthes the first.
        /// </summary>
        /// <param name="tree">The tree.</param>
        /// <returns></returns>
        public static string BreadthFirst(BinaryTree tree)
        {
            // use a generic que and enqueue the tree root node.
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(tree.Root);
            string result = "";
            // check to see if the queue is empty.
            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                if (current == null)
                    continue;
                queue.Enqueue(current.LeftChild);
                queue.Enqueue(current.RightChild);
                result += $" {current.Data} --> ";
            }
            return result;
        }
    }
}

