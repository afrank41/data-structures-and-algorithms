using System;
using Xunit;
using static MatchingBrackets.Program;

namespace MatchingBracketsTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("()([])")]
        [InlineData("ABCDEFG")]
        [InlineData("()HI[]GUYS{}")]
        public void ReturnsTrueIfBracketsOpenClose(string input)
        {
            Assert.True(MatchingBracketValidation(input));
        }

        [Theory]
        [InlineData("({)}")]
        [InlineData("HIGUYS(})")]
        [InlineData("]][]")]
        public void ReturnsFalseIfBracketsDoNotOpenClose(string input)
        {
            Assert.False(MatchingBracketValidation(input));
        }
    }
}
