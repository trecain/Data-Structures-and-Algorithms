using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    public class Node
    {
        /// <summary>
        /// Setting the properties for the node, left and right
        /// </summary>
        public int Data { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        /// <summary>
        /// Constructor for node, sets left and right node to null
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Data = value;
        }
    }
}
