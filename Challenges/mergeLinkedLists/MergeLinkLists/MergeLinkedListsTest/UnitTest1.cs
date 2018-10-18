using System;
using Xunit;
using LinkedLists.Classes;
using static MergeLinkLists.Program;

namespace MergeLinkedListsTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests if two input linked lists are able to merge if they are the same length
        /// </summary>
        [Fact]
        public void CanMergeListsIfListsAreSameLength()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);
            LinkdList LL1 = new LinkdList(node1);
            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);
            LL1.Append(node5);

            Node node6 = new Node(60);
            Node node7 = new Node(70);
            Node node8 = new Node(80);
            Node node9 = new Node(90);
            Node node10 = new Node(100);
            LinkdList LL2 = new LinkdList(node6);
            LL2.Append(node7);
            LL2.Append(node8);
            LL2.Append(node9);
            LL2.Append(node10);

            Assert.Equal(LL1.Head, MergeLists(LL1, LL2));
        }

        /// <summary>
        /// Tests if two LL's can be merged if second input LL is shorter than the first
        /// </summary>
        [Fact]
        public void CanMergeListsIfLL2IsShorterThanLL1()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);
            LinkdList LL1 = new LinkdList(node1);
            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);
            LL1.Append(node5);

            Node node6 = new Node(60);
            Node node7 = new Node(70);
            Node node8 = new Node(80);
            LinkdList LL2 = new LinkdList(node6);
            LL2.Append(node7);
            LL2.Append(node8);

            Assert.Equal(LL1.Head, MergeLists(LL1, LL2));
        }
        
        /// <summary>
        /// Tests if two LL's can be merged if second input LL is longer than the first
        /// </summary>
        [Fact]
        public void CanMergeListsIfLL2IsLongerThanLL1()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);
            LinkdList LL1 = new LinkdList(node1);
            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);
            LL1.Append(node5);

            Node node6 = new Node(60);
            Node node7 = new Node(70);
            Node node8 = new Node(80);
            Node node9 = new Node(90);
            Node node10 = new Node(100);
            Node node11 = new Node(110);
            Node node12 = new Node(120);
            LinkdList LL2 = new LinkdList(node6);
            LL2.Append(node7);
            LL2.Append(node8);
            LL2.Append(node9);
            LL2.Append(node10);
            LL2.Append(node11);
            LL2.Append(node12);

            Assert.Equal(LL1.Head, MergeLists(LL1, LL2));
        }
    }
}
