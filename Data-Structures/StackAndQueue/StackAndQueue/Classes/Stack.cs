using System;
using System.Collections.Generic;
using System.Text;
using Day06_LinkedList.Classes;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }


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
            Node temp = Peek();
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }


        /// <summary>
        /// Pushes a new node at the top of the stack
        /// </summary>
        /// <param name="node"></param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
