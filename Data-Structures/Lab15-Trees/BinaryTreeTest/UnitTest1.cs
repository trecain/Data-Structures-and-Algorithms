using System;
using Xunit;
using Lab15_Trees.Classes;
using System.Linq;

namespace BinaryTreeTest
{
    public class UnitTest1
    {
        /// <summary>
        /// property used to set the root node of the binary tree
        /// </summary>
        Node Root { get; set; }


        /// <summary>
        /// constructor used to set the root variable and build out the nodes for the tree
        /// </summary>
        public UnitTest1()
        {
            Root = new Node(60);
            //Left Root child
            Node leftRootChild = new Node(4);
            Root.LeftChild = leftRootChild;

            Node firstLeft = new Node(20);
            leftRootChild.LeftChild = firstLeft;

            Node firstRight = new Node(9);
            leftRootChild.RightChild = firstRight;

            Node secondLeft = new Node(17);
            firstRight.LeftChild = secondLeft;

            Node secondRight = new Node(25);
            firstRight.RightChild = secondRight;
            
            //Right Root child
            Node rightRootChild = new Node(90);
            Root.RightChild = rightRootChild;

            Node leftFirstRight = new Node(40);
            rightRootChild.LeftChild = leftFirstRight;

            Node rightFirstRight = new Node(21);
            rightRootChild.RightChild = rightFirstRight;

            Node rightSecondRight = new Node(30);
            rightFirstRight.RightChild = rightSecondRight;
        }

        [Fact]
        public void CanDoABinarySearch()
        {
        }

        /// <summary>
        /// Test if a preorder traversal can be done
        /// </summary>
        [Fact]
        public void CanDoAnPreOrderTraversal()
        {
            Assert.Equal("60 -Edge-> 4 -Edge-> 20 -Edge-> 9 -Edge-> 17 -Edge-> 25 -Edge-> 90 -Edge-> 40 -Edge-> 21 -Edge-> 30", String.Join(" -Edge-> ", BinaryTree.PreOrder(Root).Select(val => (int)val.Data)));
        }


        /// <summary>
        /// Test if an inorder traversal can be done
        /// </summary>
        [Fact]
        public void CanDoAnInOrderTraversal()
        {
            Assert.Equal("20 -Edge-> 4 -Edge-> 17 -Edge-> 9 -Edge-> 25 -Edge-> 60 -Edge-> 40 -Edge-> 90 -Edge-> 21 -Edge-> 30", String.Join(" -Edge-> ", BinaryTree.InOrder(Root).Select(val => (int)val.Data)));
        }


        /// <summary>
        /// Test if a postorder traversal can be done
        /// </summary>
        [Fact]
        public void CanDoAPostOrderTraversal()
        {
            Assert.Equal("20 -Edge-> 17 -Edge-> 25 -Edge-> 9 -Edge-> 4 -Edge-> 40 -Edge-> 30 -Edge-> 21 -Edge-> 90 -Edge-> 60", String.Join(" -Edge-> ", BinaryTree.PostOrder(Root).Select(val => (int)val.Data)));
        }
    }
}
