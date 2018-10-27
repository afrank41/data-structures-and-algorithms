using System;
using System.Collections.Generic;
using Tree.Classes;
using Xunit;

namespace TreeTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to make sure a preorder traversal is done correctly
        /// </summary>
        [Fact]
        public void PreOrderTraversalWorks()
        {
            Node node6 = new Node(6, null, null);
            Node node5 = new Node(5, null, null);
            Node node4 = new Node(4, null, null);
            Node node3 = new Node(3, null, null);
            Node node2 = new Node(2, node5, node6);
            Node node1 = new Node(1, node3, node4);
            Node root = new Node(0, node1, node2);
            BinaryTree tree = new BinaryTree(root);

            List<Node> list = tree.PreOrder(root);

            Assert.Equal(0, list[0].Value);
        }

        /// <summary>
        /// Test to make sure an inorder traversal is done correctly
        /// </summary>
        [Fact]
        public void InOrderTraversalWorks()
        {
            Node node6 = new Node(6, null, null);
            Node node5 = new Node(5, null, null);
            Node node4 = new Node(4, null, null);
            Node node3 = new Node(3, null, null);
            Node node2 = new Node(2, node5, node6);
            Node node1 = new Node(1, node3, node4);
            Node root = new Node(0, node1, node2);
            BinaryTree tree = new BinaryTree(root);

            List<Node> list = tree.InOrder(root);

            Assert.Equal(0, list[list.Count/2].Value);
        }

        /// <summary>
        /// Test to make sure a postorder traversal is done correctly
        /// </summary>
        [Fact]
        public void PostOrderTraversalWorks()
        {
            Node node6 = new Node(6, null, null);
            Node node5 = new Node(5, null, null);
            Node node4 = new Node(4, null, null);
            Node node3 = new Node(3, null, null);
            Node node2 = new Node(2, node5, node6);
            Node node1 = new Node(1, node3, node4);
            Node root = new Node(0, node1, node2);
            BinaryTree tree = new BinaryTree(root);

            List<Node> list = tree.PostOrder(root);

            Assert.Equal(0, list[list.Count - 1].Value);
        }

        /// <summary>
        /// Tests to make sure node can be returned after successful search on binary tree
        /// </summary>
        [Theory]
        [InlineData(50)]
        [InlineData(150)]
        [InlineData(300)]
        public void CanSearchBinaryTree(int value)
        {
            Node node12 = new Node(350, null, null);
            Node node11 = new Node(250, null, null);
            Node node10 = new Node(150, null, null);
            Node node9 = new Node(50, null, null);
            Node node8 = new Node(300, node11, node12);
            Node node7 = new Node(100, node9, node10);
            Node root = new Node(200, node7, node8);
            BinarySearchTree tree = new BinarySearchTree(root);

            Assert.Equal(value, tree.Search(root, value).Value);
        }

        /// <summary>
        /// Tests to make sure a node with a value of -1 is returned from a search on a binary tree
        /// where a node with the given value does not exist
        /// </summary>
        [Theory]
        [InlineData(75)]
        [InlineData(210)]
        [InlineData(140)]
        public void SearchReturnsNegativeOneIfNodeDoesNotExist(int value)
        {
            Node node12 = new Node(350, null, null);
            Node node11 = new Node(250, null, null);
            Node node10 = new Node(150, null, null);
            Node node9 = new Node(50, null, null);
            Node node8 = new Node(300, node11, node12);
            Node node7 = new Node(100, node9, node10);
            Node root = new Node(200, node7, node8);
            BinarySearchTree tree = new BinarySearchTree(root);

            Assert.Equal(-1, tree.Search(root, value).Value);
        }

        [Theory]
        [InlineData(75)]
        [InlineData(210)]
        [InlineData(140)]
        public void CanAddNodeToTree(int value)
        {
            Node node12 = new Node(350, null, null);
            Node node11 = new Node(250, null, null);
            Node node10 = new Node(150, null, null);
            Node node9 = new Node(50, null, null);
            Node node8 = new Node(300, node11, node12);
            Node node7 = new Node(100, node9, node10);
            Node root = new Node(200, node7, node8);
            BinarySearchTree tree = new BinarySearchTree(root);

            tree.Add(root, value);

            Assert.Equal(value, tree.Search(root, value).Value);
        }
    }
}
