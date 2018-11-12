using System;
using Xunit;
using static BreadthFirstTraversal.Program;
using Lab15_Trees.Classes;

namespace BreadthFirstTraversalTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test that a normal breadth test can be completed
        /// </summary>
        [Fact]
        public void CanPerformABreadthTest()
        {
            Assert.Equal(" 2 -->  7 -->  5 -->  2 -->  6 -->  9 -->  5 -->  11 -->  4 --> ", BreadthFirst(SampleTree()));      
        }


        /// <summary>
        /// traverses all the right nodes
        /// </summary>
        [Fact]
        public void CanTraverseRight()
        {
            Node root = new Node(9);
            BinaryTree tree = new BinaryTree(root);
            root.RightChild = new Node(8);
            root.RightChild.RightChild = new Node(4);

            Assert.Equal(" 9 -->  8 -->  4 --> ", BreadthFirst(tree));
        }


        /// <summary>
        /// traverses all the left nodes
        /// </summary>
        [Fact]
        public void CanTraverseLeft()
        {
            Node root = new Node(9);
            BinaryTree tree = new BinaryTree(root);
            root.LeftChild = new Node(8);
            root.LeftChild.LeftChild = new Node(4);
            Assert.Equal(" 9 -->  8 -->  4 --> ", BreadthFirst(tree));
        }
    }
}
