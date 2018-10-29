using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        public Node TopNode { get; set; }
        public int Size { get; set; } = 0;

        /// <summary>
        /// Constructs a new stack
        /// </summary>
        /// <param name="node">Node to be put in the stack</param>
        public Stack(Node node)
        {
            TopNode = node;
            Size = 1;
        }


        /// <summary>
        /// Views the the top node
        /// </summary>
        /// <returns>Top Node</returns>
        public Node View()
        {
            return TopNode;
        }


        /// <summary>
        /// Top node removal
        /// </summary>
        /// <returns>removed Node</returns>
        public Node Pop()
        {
            try 
            {
                Size--;
                Node top = View();
                TopNode = top.Next;
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
