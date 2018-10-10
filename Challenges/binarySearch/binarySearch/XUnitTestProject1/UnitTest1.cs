using System;
using Xunit;
using static ArrayBinarySearch.Program;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnCorrectIndex()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int value = 3;

            Assert.Equal(2, BinarySearch(array, value));
        }

        [Fact]
        public void CannotReturnCorrectIndex()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int value = 6;

            Assert.Equal(-1, BinarySearch(array, value));
        }

        [Fact]
        public void CanReturnCorrectIndexIfValueIsFirstInArray()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int value = 1;

            Assert.Equal(0, BinarySearch(array, value));
        }

        [Fact]
        public void CanReturnCorrectIndexIfValueIsLastInArray()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int value = 5;

            Assert.Equal(4, BinarySearch(array, value));
        }
    }
}