using System;
using Lab15_Trees.Classes;
using System.Linq;

namespace Lab15_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Binary Trees");
                CreateABinaryTree();
                BinarySearchTree();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }


        /// <summary>
        /// creates a binary tree
        /// </summary>
        public static void CreateABinaryTree()
        {
            Node root = new Node(60);
            //Left root child
            Node leftRootChild = new Node(4);
            root.LeftChild = leftRootChild;

            Node firstLeft = new Node(20);
            leftRootChild.LeftChild = firstLeft;

            Node firstRight = new Node(9);
            leftRootChild.RightChild = firstRight;

            Node secondLeft = new Node(17);
            firstRight.LeftChild = secondLeft;

            Node secondRight = new Node(25);
            firstRight.RightChild = secondRight;
            
            //Right root child
            Node rightRootChild = new Node(90);
            root.RightChild = rightRootChild;

            Node leftFirstRight = new Node(40);
            rightRootChild.LeftChild = leftFirstRight;

            Node rightFirstRight = new Node(21);
            rightRootChild.RightChild = rightFirstRight;

            Node rightSecondRight = new Node(30);
            rightFirstRight.RightChild = rightSecondRight;
            RunBinaryTreeMethods(root);
        }

       
        /// <summary>
        /// Runs pre, in, post order methods in binary tree
        /// </summary>
        /// <param name="root"></param>
        public static void RunBinaryTreeMethods(Node root)
        {
            ///<summary>
            /// Preorder
            /// </summary>
            Console.WriteLine("+++++++++++++++++++++++++++++ PreOrder Traversal +++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine(String.Join(" -Edge-> ", BinaryTree.PreOrder(root).Select(val => (int)val.Data)));
            Console.WriteLine("");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("+++++++++++++++++++++++++++++ InOrder Traversal ++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine(String.Join(" -Edge-> ", BinaryTree.InOrder(root).Select(val => (int)val.Data)));
            Console.WriteLine("");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("+++++++++++++++++++++++++++++ PostOrder Traversal ++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine(String.Join(" -Edge-> ", BinaryTree.PostOrder(root).Select(val => (int)val.Data)));
            Console.WriteLine("");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }


        /// <summary>
        /// calls and sets up the binary search tree
        /// </summary>
        public static void BinarySearchTree()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("+++++++++++++++++++++++++++++ Binary Search Tree +++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine("");
            Node favoriteNumberNode = new Node(3);
            BinarySearchTree BST = new BinarySearchTree(new BinaryTree(favoriteNumberNode));
            Console.WriteLine("");
            BST.Add(new Node(80));
            BST.Add(new Node(9));
            BST.Add(new Node(19));
            BST.Add(new Node(90));
            Console.WriteLine(String.Join(" -Edge-> ", BinaryTree.PreOrder(BST.BT.Root).Select(val => (int)val.Data)));
            Console.WriteLine("");
            Console.WriteLine("Search returns the nine node: " + BST.Search(9).Data);
        }
    }
}
