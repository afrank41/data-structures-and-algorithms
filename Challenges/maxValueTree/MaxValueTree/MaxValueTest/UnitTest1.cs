using System;
using Tree.Classes;
using Xunit;
using static MaxValueTree.Program;

namespace MaxValueTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        [InlineData(25)]
        public void CanFindMaxValueInTree(int value)
        {
            Node node6 = new Node(6, null, null);
            Node node5 = new Node(5, null, null);
            Node node4 = new Node(value, null, null);
            Node node3 = new Node(3, null, null);
            Node node2 = new Node(2, node5, node6);
            Node node1 = new Node(1, node3, node4);
            Node root = new Node(0, node1, node2);
            BinaryTree tree = new BinaryTree(root);

            Assert.Equal(value, MaxValue(tree));
        }
    }
}
