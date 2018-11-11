using System;
using Xunit;
using Lab15_Trees.Classes;
using FizzBuzzTree;

namespace FizzBuzzTreeTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test that the proper value is being converted
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="value"></param>
        [Theory]
        [InlineData(" Fizz --> ", 33)]
        [InlineData(" FizzBuzz --> ", 30)]
        [InlineData(" Buzz --> ", 10)]
        [InlineData(" 1 -->", 1)]
        public void TestThatFizzBuzzIsWorking(string expected, int value)
        {
            BinaryTree tree = new BinaryTree(new Node(value));
            BinarySearchTree bst = new BinarySearchTree(tree);

            Assert.Equal(expected, Program.FizzBuzzTree(bst.BT.Root));
        }
    }
}
