using System;
using Xunit;
using static MatchingBrackets.Program;

namespace MatchingBracketsTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that bracket validation method returns true with a valid input string
        /// </summary>
        /// <param name="input">string to be tested as method parameter</param>
        [Theory]
        [InlineData("()([])")]
        [InlineData("([{}])")]
        [InlineData("()[]{}")]
        public void ReturnsTrueIfBracketsOpenClose(string input)
        {
            Assert.True(MatchingBracketValidation(input));
        }

        /// <summary>
        /// Tests that bracket validation method returns false with invalid input string
        /// </summary>
        /// <param name="input">string to be tested as method parameter</param>
        [Theory]
        [InlineData("({)}")]
        [InlineData("()[[")]
        [InlineData("]][]")]
        public void ReturnsFalseIfBracketsDoNotOpenClose(string input)
        {
            Assert.False(MatchingBracketValidation(input));
        }

        /// <summary>
        /// Tests that bracket validation method returns true 
        /// if there is more characters than just brackets
        /// or no brackets are present
        /// </summary>
        /// <param name="input">string to be tested as method parameter</param>
        [Theory]
        [InlineData("Decakitty")]
        [InlineData("HIGUYS()()()")]
        [InlineData("!@#$%^123")]
        public void ReturnsTrueIfInputHasLettersOrSymbols(string input)
        {
            Assert.True(MatchingBracketValidation(input));
        }
    }
}
