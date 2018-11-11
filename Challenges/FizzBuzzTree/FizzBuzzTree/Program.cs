using System;
using Lab15_Trees.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Challenge 16: Fizz Buzz Using Trees");
            // Initializes a binary tree and populates it with nodes
            BinaryTree tree = new BinaryTree(new Node(33));
            BinarySearchTree bst = new BinarySearchTree(tree);
            for (int i = 1; i < 10; i++)
            {
                bst.Add(new Node(i));
            }

            FizzBuzzTree(bst.BT.Root); 
        }


        /// <summary>
        /// Traverses through the tre and returns whether it's Fizz, Buzz, FizzBuzz
        /// </summary>
        /// <param name="root"></param>
        public static string FizzBuzzTree(Node root)
        {
            int value = (int)root.Data;
            string result = "";
            if (value % 15 == 0)
            {
                result += " FizzBuzz --> ";
                Console.Write(" FizzBuzz --> ");
            }
            else if (value % 5 == 0)
            {
                Console.Write(" Buzz --> ");
                result += " Buzz --> ";
            }
            else if (value % 3 == 0)
            {
                Console.Write(" Fizz --> ");
                result += " Fizz --> ";
            }
            else
            {
                Console.Write($" {value} --> ");
                result += $" {value} -->";
            }

            if (root.LeftChild != null)
                FizzBuzzTree(root.LeftChild);

            if (root.RightChild != null)
                FizzBuzzTree(root.RightChild);
            return result;
        }
    }
}
