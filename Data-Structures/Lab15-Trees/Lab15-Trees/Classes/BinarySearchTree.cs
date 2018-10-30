using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15_Trees.Classes
{
    class BinarySearchTree
    {
        /// <summary>
        /// gets and sets a binary tre 
        /// </summary>
        public Node Root { get; set; }
        

        /// <summary>
        /// Binary search tree constructor
        /// </summary>
        /// <param name="bt"></param>
        public  BinarySearchTree(Node root)
        {
            Root = root;
        }


        /// <summary>
        /// adds a node to the binary search tree
        /// </summary>
        /// <param name="node"></param>
        public void Add(Node node)
        {
           Node root = Root;
           if (Root.Data == null)
           {
               Root = node;
           }
           else if ((int)node.Data < (int)Root.Data)
           {
               Root.LeftChild = node;
           }
           else if ((int)node.Data > (int)Root.Data)
            {
                Root.RightChild = node;
            }
        }

        
        /// <summary>
        /// searches binary tree comparing new node value to root node value and placing node left or right
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Node Search(Node node)
        {
            Node root = Root;
            while (root != null)
            {
                if ((int)node.Data == (int)root.Data)
                {
                    return root;
                }
                else if ((int)node.Data < (int)root.Data)
                    root = root.LeftChild;
                else
                    root = root.RightChild;
            }
            return null;
        }
    }
}
