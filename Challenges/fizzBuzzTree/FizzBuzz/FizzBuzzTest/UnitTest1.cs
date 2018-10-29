using System;
using Tree.Classes;
using Xunit;
using static FizzBuzz.Program;

namespace FizzBuzzTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests to make sure Fizz is being added to a list properly
        /// </summary>
        /// <param name="index">index of list item to check</param>
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void ReturnsFizz(int index)
        {
            Node node2 = new Node(9, null, null);
            Node node1 = new Node(6, null, null);
            Node root = new Node(3, node1, node2);

            Assert.Equal("Fizz", FizzBuzzTree(root)[index]);
        }

        /// <summary>
        /// Tests to make sure Buzz is being added to a list properly
        /// </summary>
        /// <param name="index">index of list item to check</param>
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void ReturnsBuzz(int index)
        {
            Node node2 = new Node(20, null, null);
            Node node1 = new Node(10, null, null);
            Node root = new Node(5, node1, node2);

            Assert.Equal("Buzz", FizzBuzzTree(root)[index]);
        }

        /// <summary>
        /// Tests to make sure FizzBuzz is being added to a list properly
        /// </summary>
        /// <param name="index">index of list item to check</param>
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void ReturnsFizzBuzz(int index)
        {
            Node node2 = new Node(45, null, null);
            Node node1 = new Node(30, null, null);
            Node root = new Node(15, node1, node2);

            Assert.Equal("FizzBuzz", FizzBuzzTree(root)[index]);
        }
    }
}
