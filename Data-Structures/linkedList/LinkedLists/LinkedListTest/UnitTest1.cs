using System;
using Xunit;
using LinkedLists.Classes;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(20)]
        [InlineData("bird")]
        [InlineData(true)]
        public void LLCanAdd(object value)
        {
            Node node1 = new Node(0, 7);
            Node node2 = new Node(0, "cat");
            Node node3 = new Node(0, "dog");
            Node node4 = new Node(0, value);

            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Add(node4);

            Assert.Equal(list.Head.Value, value);
        }

        [Theory]
        [InlineData(20)]
        [InlineData("bird")]
        [InlineData(true)]
        public void LLCanAppend(object value)
        {
            Node node1 = new Node(0, 7);
            Node node2 = new Node(0, "cat");
            Node node3 = new Node(0, "dog");
            Node node4 = new Node(0, value);

            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);

            Assert.Equal(value, list.Find(value).Value);
        }

        [Theory]
        [InlineData(20)]
        [InlineData("bird")]
        [InlineData(true)]
        public void LLCanAddBefore(object value)
        {
            Node node1 = new Node(0, 7);
            Node node2 = new Node(0, "cat");
            Node node3 = new Node(0, "dog");
            Node node4 = new Node(0, value);

            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.AddBefore(node4, node3);

            Assert.Equal(value, list.Find(value).Value);
        }

        [Theory]
        [InlineData(20)]
        [InlineData("bird")]
        [InlineData(true)]
        public void LLCanAddAfter(object value)
        {
            Node node1 = new Node(0, 7);
            Node node2 = new Node(0, "cat");
            Node node3 = new Node(0, "dog");
            Node node4 = new Node(0, value);

            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.AddAfter(node4, node2);

            Assert.Equal(value, list.Find(value).Value);
        }

        [Theory]
        [InlineData(20)]
        [InlineData("bird")]
        [InlineData(true)]
        public void LLCanFind(object value)
        {
            Node node1 = new Node(0, 7);
            Node node2 = new Node(0, "cat");
            Node node3 = new Node(0, "dog");
            Node node4 = new Node(0, value);

            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);

            Assert.Equal(value, list.Find(value).Value);
        }
    }
}
