using System;
using Xunit;
using LinkedLists.Classes;
using static ReverseLinkedList.Program;

namespace ReverseLinkedListTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Checks to see if an even lengthed linked list is a palindrome
        /// </summary>
        [Fact]
        public void CheckIfListIsReversed()
        {
            Node node1 = new Node("A");
            Node node2 = new Node("B");
            Node node3 = new Node("C");
            Node node4 = new Node("D");
            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);

            Assert.Equal(node4, ReverseLL(list).Head);
        }
    }
}
