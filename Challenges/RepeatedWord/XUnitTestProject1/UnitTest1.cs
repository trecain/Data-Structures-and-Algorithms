using System;
using Xunit;
using Hashtables.Classes;
using RepeatedWord;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests repeating words with expected
        /// </summary>
        /// <param name="input">the input string</param>
        /// <param name="word">the expected repeat</param>
        [Theory]
        [InlineData("you can dane if you want to", "you")]
        [InlineData("I cant stand the rain", null)]
        [InlineData("Hey yall what yall doing?", "yall")]
        public void CanTestRepeatWords(string input, string word)
        {
            string repeatedWord = Program.RepeatedWord(input);
            Assert.Equal(word, repeatedWord);
        }
    }
}
