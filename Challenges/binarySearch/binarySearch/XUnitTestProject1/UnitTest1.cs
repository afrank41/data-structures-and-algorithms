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
            int[] array = new int[7] { 4, 8, 15, 16, 23, 42, 50 };
            int value = 15;

            Assert.Equal(2, BinarySearch(array, value));
        }

        [Fact]
        public void CannotReturnCorrectIndex()
        {
            int[] array = new int[7] { 4, 8, 15, 16, 23, 42, 50 };
            int value = 100;

            Assert.Equal(-1, BinarySearch(array, value));
        }

        [Fact]
        public void CanReturnCorrectIndexIfValueIsFirstInArray()
        {
            int[] array = new int[7] { 4, 8, 15, 16, 23, 42, 50 };
            int value = 4;

            Assert.Equal(0, BinarySearch(array, value));
        }

        [Fact]
        public void CanReturnCorrectIndexIfValueIsLastInArray()
        {
            int[] array = new int[7] { 4, 8, 15, 16, 23, 42, 50 };
            int value = 50;

            Assert.Equal(6, BinarySearch(array, value));
        }
    }
}
