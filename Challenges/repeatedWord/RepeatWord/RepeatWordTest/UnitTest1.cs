using System;
using Xunit;
using static RepeatWord.Program;

namespace RepeatWordTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Determines whether this instance [can find repeated word].
        /// </summary>
        [Fact]
        public void CanFindRepeatedWord()
        {
            string s = "The quick brown fox jumps over the fence";

            Assert.Equal("the", RepeatedWord(s));
        }

        /// <summary>
        /// Determines whether this instance [cannot find repeated word].
        /// </summary>
        [Fact]
        public void CannotFindRepeatedWord()
        {
            string s = "This sentence sucks because no words repeat";

            Assert.Equal("No Repeated Words", RepeatedWord(s));
        }

        /// <summary>
        /// Cannot the find repeated word with empty string.
        /// </summary>
        [Fact]
        public void CannotFindRepeatedWordWithEmptyString()
        {
            string s = "";

            Assert.Equal("No Repeated Words", RepeatedWord(s));

        }
    }
}
