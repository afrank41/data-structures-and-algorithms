using System;
using Xunit;
using static NthFromEnd.Program;
using LinkedLists.Classes;

namespace NthFromEndTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to see if NthFromEnd method works properly
        /// </summary>
        [Fact]
        public void CanFindNthNumberFromEnd()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);
            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);
            list.Append(node5);

            Assert.Equal(20, NthNodeFromEnd(3));
        }

        /// <summary>
        /// Test to see if NthNodeFromEnd method returns Exception if parameter is bad
        /// </summary>
        /// <param name="value">inline data that will cause test to pass. in this case -1 and 10 with throw an exception</param>
        [Theory]
        [InlineData(-1)]
        [InlineData(10)]
        public void CannotFindNthNumberFromEnd(int value)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);
            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);
            list.Append(node5);

            Assert.Equal("Your input is bad", NthNodeFromEnd(value));
        }
    }
}
