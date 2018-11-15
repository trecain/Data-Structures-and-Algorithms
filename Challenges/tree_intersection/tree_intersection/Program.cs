using System;
using Hashtables.Classes;
using Lab15_Trees.Classes;
using System.Collections.Generic;
using Node = Lab15_Trees.Classes.Node;

namespace tree_intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge: Tree Intersection Challenge");
        }

        public static BinaryTree CreateTreeOne()
        {
         
            Node root = new Node(9);
            Node eight = new Node(8);
            Node nine = new Node(9);
            Node one = new Node(1);
            root.LeftChild = eight;
            eight.RightChild = nine;
            root.RightChild = one;

            BinaryTree bt = new BinaryTree(root);
            return bt;
     
        }

        public static BinaryTree CreateTreeTwo()
        {

            Node rootTwo = new Node(2);
            Node eight = new Node(8);
            Node nine = new Node(9);
            Node three = new Node(3);

            rootTwo.LeftChild = eight;
            eight.RightChild = nine;
            rootTwo.RightChild = three;

            BinaryTree bt = new BinaryTree(rootTwo);
            return bt;

        }

        public static List<string> TreeIntersection(BinaryTree one, BinaryTree two)
        {
            Hashtable hashTable = new Hashtable(10);
            List<string> values = new List<string>();

        }


    }
}
