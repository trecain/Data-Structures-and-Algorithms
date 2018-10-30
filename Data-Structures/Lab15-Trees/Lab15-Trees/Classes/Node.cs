using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15_Trees.Classes
{
    public class Node
    {
        /// <summary>
        /// Setting the properties for the node, left and right
        /// </summary>
        public Object Data { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        /// <summary>
        /// Constructor for node, sets left and right node to null
        /// </summary>
        /// <param name="value"></param>
        public Node(Object value)
        {
            Data = value;
        }
    }
}
