using System;
using Xunit;
using StackAndQueue.Classes;
using multi_bracket_validation;

namespace MultiBracketValidation
{
    public class UnitTest1
    {
        /// <summary>
        /// Validates multi-bracket testing
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="expected">if set to <c>true</c> [expected].</param>
        [Theory]
        [InlineData("{}", true)]
        [InlineData("{}{}", true)]
        [InlineData("{}(){}", true)]
        [InlineData("{}[({}]", false)]
        [InlineData("{}(](", false)]
        [InlineData("{}{(})", false)]
        public void CanValidateMultiBrackets(string inputString, bool expectedOutput)
        {
            Assert.Equal(expectedOutput, Program.MultiBracketValidation(inputString));
        }

        /// <summary>
        /// can return paired bracket
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="expected">The expected.</param>
        [Theory]
        [InlineData("(", ")")]
        [InlineData(")", "(")]
        [InlineData("{", "}")]
        [InlineData("}", "{")]
        [InlineData("[", "]")]
        [InlineData("]", "[")]
        public void CanReturnPairedBracket(string character, string expectedOutput)
        {
            Assert.Equal(expectedOutput[0], Program.BracketPair(character[0]));
        }
    }
}

