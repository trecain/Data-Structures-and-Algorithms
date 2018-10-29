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
        public int Value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }

        /// <summary>
        /// Constructor for node, sets left and right node to null
        /// </summary>
        /// <param name="value"></param>
        public Node (int value)
        {
            Value = Value;
            left = null;
            right = null;
        }

    }
}
