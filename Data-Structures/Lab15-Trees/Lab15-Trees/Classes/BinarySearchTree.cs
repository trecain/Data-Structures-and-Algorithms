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
        public BinaryTree BT { get; set; }
        

        /// <summary>
        /// Binary search tree constructor
        /// </summary>
        /// <param name="bt"></param>
        public  BinarySearchTree(BinaryTree binaryTree)
        {
            BT = binaryTree;
        }


        /// <summary>
        /// adds a node to the binary search tree
        /// </summary>
        /// <param name="node"></param>
        public void Add(Node node)
        {
            Node root = BT.Root;

            if (root == null)
            {
                BT.Root = node;
            }
            else
            {
                Node temp = root;
                while (root != null)
                {
                    temp = root;
                    if ((int)node.Data < (int)node.Data)
                        root = root.RightChild;
                    if ((int)node.Data < (int)root.Data)
                        root = root.LeftChild;
                }

                if ((int)node.Data > (int)temp.Data)
                    temp.RightChild = node;
                else
                    temp.LeftChild = node;
            }
        }

        
        /// <summary>
        /// searches binary tree comparing new node value to root node value and placing node left or right
        /// </summary>
        /// <param name="value">The value you are looking for on the tree</param>
        /// <returns></returns>
        public Node Search(int value)
        {
            Node root = BT.Root;
            while (root != null)
            {
                if ((int)root.Data == value)
                    return root;
                else if ((int)root.Data < value)
                    root = root.RightChild;
                else
                    root = root.LeftChild;
            }
            ///<summary>
            /// If nothing is found return null
            /// </summary>
            return null;
        }

    }
}
