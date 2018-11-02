using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        public int Size { get; set; } = 0;

        /// <summary>
        /// Constructs a new stack
        /// </summary>
        /// <param name="node">Node to be put in the stack</param>
        public Stack(Node node)
        {
            Top = node;
        }


        /// <summary>
        /// Views the the top node
        /// </summary>
        /// <returns>Top Node</returns>
        public Node Peek()
        {
            return Top;
        }


        /// <summary>
        /// Top node removal
        /// </summary>
        /// <returns>removed Node</returns>
        public Node Pop()
        {
            try
            {
                Node top = Peek();
                Top = top.Ne
                top.Next = null;
                return top;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Pushes a new node at the top of the stack
        /// </summary>
        /// <param name="node"></param>
        public void Push(Node node)
        {
            node.Next = TopNode;
            TopNode = node;
            Size++;
        }
    }
}
}
