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
        /// BinaryTree constructor
        /// </summary>
        /// <param name="root"></param>
        public BinaryTree(Node root)
        {
            Root = root;
        }


        /// <summary>
        /// Preorder traversal
        /// </summary>
        /// <param name="root"></param>
        /// <param name="arrayOfNodes"></param>
        /// <returns></returns>
        public static List<Node> PreOrder(Node root, List<Node> arrayOfNodes = null)
        {
            if (root == null)
                return null;
            if (arrayOfNodes == null)
                arrayOfNodes = new List<Node>();
            arrayOfNodes.Add(root);
            if (root.LeftChild != null)
                PreOrder(root.LeftChild, arrayOfNodes);
            if (root.RightChild != null)
                PreOrder(root.RightChild, arrayOfNodes);
            return arrayOfNodes;
        }


        /// <summary>
        /// Inorder traversal
        /// </summary>
        /// <param name="root"></param>
        /// <param name="arrayOfNodes"></param>
        /// <returns></returns>
        public static List<Node> InOrder(Node root, List<Node> arrayOfNodes = null)
        {
            if (root == null)
                return null;
            if (arrayOfNodes == null)
                arrayOfNodes = new List<Node>();
            if (root.LeftChild != null)
                InOrder(root.LeftChild, arrayOfNodes);
            arrayOfNodes.Add(root);
            if (root.RightChild != null)
                InOrder(root.RightChild, arrayOfNodes);
            return arrayOfNodes;
        }


        /// <summary>
        /// Post order traversal
        /// </summary>
        /// <param name="root"></param>
        /// <param name="arrayOfNodes"></param>
        /// <returns></returns>
        public static List<Node> PostOrder(Node root, List<Node> arrayOfNodes = null)
        {
            if (root == null)
                return null; 
            if (arrayOfNodes == null)
                arrayOfNodes = new List<Node>();
            if (root.LeftChild != null)
                PostOrder(root.LeftChild, arrayOfNodes);
            if (root.RightChild != null)
                PostOrder(root.RightChild, arrayOfNodes);
            arrayOfNodes.Add(root);
            return arrayOfNodes;
        }
    }
}
