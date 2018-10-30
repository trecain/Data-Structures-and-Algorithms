using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15_Trees.Classes
{
    class BinaryTree
    {
        /// <summary>
        /// Gets and sets Root node for the tree
        /// </summary>
        public Node Root { get; set; }


        /// <summary>
        /// Sets the root node of the binary tree
        /// </summary>
        /// <param name="root"></param>
        public BinaryTree(Node root)
        {
            Root = root;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public void Add(Node node)
        {
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(Root);
                while (queue.Count > 0)
                {
                    Node curr = queue.Dequeue();
                    if (curr.GetRight() != null && curr.GetLeft() != null)
                    {
                        queue.Enqueue(node.GetLeft());
                        queue.Enqueue(node.GetRight());
                    }
                    else
                    {
                        if (curr.GetLeft() == null)
                        {
                            curr.SetLeft(node);
                        }

                        if (curr.GetLeft() == null)
                        {
                            curr.SetRight(node);
                        }

                    }
                }
            }
        }

        public Node[] PreOrder(Node node)
        {
            Node[] nodes = new Node[0];
            nodes[0] = node;

            if (node.GetLeft() != null)
            {
            }
        }
    }
}
