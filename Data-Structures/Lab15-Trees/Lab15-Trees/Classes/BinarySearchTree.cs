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



        public void Add(Node node)
        {
            Node curr = Root;
            if (((int)node.Data <= (int)curr.Data))
            {
                if (curr.LeftChild == null)
                {
                    curr.LeftChild = node;
                }
                else
                {
                    Add(node);
                }
            }
            else
            {
                if (curr.RightChild == null)
                {
                    curr.RightChild = node;
                }
                else
                {
                    Add(node);
                }
            }
        }


        
        public Node Search(int value)
        {
            Node root = Root;
            while (root != null)
            {
                if (value == (int)root.Data)
                {
                    return root;
                }

                if (value > (int)root.Data)
                {
                    root = root.RightChild;
                }
                else
                {
                    root = root.LeftChild;
                }
            }
            return null;
        }
    }
}
