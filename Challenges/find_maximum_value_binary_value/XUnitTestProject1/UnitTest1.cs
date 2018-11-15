using System;
using Xunit;
using Lab15_Trees.Classes;
using find_maximum_value_binary_value;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// can returen the node with the max value
        /// </summary>
        [Fact]
        public void CanFindTheMaxNodeValue()
        {
            Node root = new Node(3);
            root.LeftChild = new Node(8);
            root.RightChild = new Node(7);

            root.LeftChild.LeftChild = new Node(2);
            root.LeftChild.RightChild = new Node(9);
            root.LeftChild.RightChild.LeftChild = new Node(5);
            root.LeftChild.RightChild.RightChild = new Node(12);
            root.RightChild.RightChild = new Node(9);
            root.RightChild.RightChild.LeftChild = new Node(4);
            BinaryTree tree = new BinaryTree(root);
            Assert.Equal(12, Program.FindMaxValue(tree));
        }


        /// <summary>
        /// finds the max of the left side
        /// </summary>
        [Fact]
        public void CanFindMaxLeftValue()
        {
            Node root = new Node(3);
            root.LeftChild = new Node(8);
            root.RightChild = new Node(7);

            root.LeftChild.LeftChild = new Node(2);
            root.LeftChild.RightChild = new Node(9);
            root.LeftChild.RightChild.LeftChild = new Node(5);
            root.LeftChild.RightChild.RightChild = new Node(12);
            root.RightChild.RightChild = new Node(9);
            root.RightChild.RightChild.LeftChild = new Node(4);

            BinaryTree tree = new BinaryTree(root);
            tree.Root.LeftChild.Data = int.MaxValue;
            Assert.Equal(int.MaxValue, Program.FindMaxValue(tree));
        }


        /// <summary>
        /// can find the max value of the right nodes
        /// </summary>
        [Fact]
        public void CanFindMaxRightValue()
        {
            Node root = new Node(3);
            root.LeftChild = new Node(8);
            root.RightChild = new Node(7);

            root.LeftChild.LeftChild = new Node(2);
            root.LeftChild.RightChild = new Node(9);
            root.LeftChild.RightChild.LeftChild = new Node(5);
            root.LeftChild.RightChild.RightChild = new Node(12);
            root.RightChild.RightChild = new Node(9);
            root.RightChild.RightChild.LeftChild = new Node(4);

            BinaryTree tree = new BinaryTree(root);
            tree.Root.RightChild.Data = int.MaxValue;
            Assert.Equal(int.MaxValue, Program.FindMaxValue(tree));
        }
    }
}
