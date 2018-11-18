using System;
using Xunit;
using static MostCommonWord.Program;

namespace CommonWordTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests to ensure the most repeated word is returned
        /// </summary>
        [Fact]
        public void CanFindMostRepeatedWord()
        {
            string input = "Taco cat ate a taco";

            Assert.Equal("taco", MostRepeatedWord(input));
        }

        /// <summary>
        /// Tests to return the first most repeated word if two words appear the same amount of times
        /// </summary>
        [Fact]
        public void TwoRepeatedWordsAppearTheSameAmount()
        {
            string input = "lizard cat dog cat dog chicken";

            Assert.Equal("cat", MostRepeatedWord(input));
        }

        /// <summary>
        /// Tests for if there is no repeated words
        /// </summary>
        [Fact]
        public void NoRepeatedWords()
        {
            string input = "Sorry, no repeated words in this string";

            Assert.Equal("No repeated words", MostRepeatedWord(input));
        }

    }
}
