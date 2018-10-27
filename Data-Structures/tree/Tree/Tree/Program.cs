using System;
using System.Collections.Generic;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node6 = new Node(6, null, null);
            Node node5 = new Node(5, null, null);
            Node node4 = new Node(4, null, null);
            Node node3 = new Node(3, null, null);
            Node node2 = new Node(2, node5, node6);
            Node node1 = new Node(1, node3, node4);
            Node root = new Node(0, node1, node2);
            BinaryTree tree = new BinaryTree(root);

            Console.WriteLine("BINARY TREE");
            Console.WriteLine("Preorder:");
            List<Node> preorder = tree.PreOrder(root);
            foreach(Node item in preorder)
            {
                Console.WriteLine(item.Value);
            }
            preorder.Clear();

            Console.WriteLine("\nInorder:");
            List<Node> inorder = tree.InOrder(root);
            foreach(Node item in inorder)
            {
                Console.WriteLine(item.Value);
            }
            inorder.Clear();

            Console.WriteLine("\nPostorder:");
            List<Node> postorder = tree.PostOrder(root);
            foreach(Node item in postorder)
            {
                Console.WriteLine(item.Value);
            }
            postorder.Clear();

            Console.WriteLine("\n========================");
            Node node12 = new Node(350, null, null);
            Node node11 = new Node(250, null, null);
            Node node10 = new Node(150, null, null);
            Node node9 = new Node(50, null, null);
            Node node8 = new Node(300, node11, node12);
            Node node7 = new Node(100, node9, node10);
            Node root2 = new Node(200, node7, node8);
            BinarySearchTree binaryTree = new BinarySearchTree(root2);

            Node newNode = new Node(25, null, null);

            Console.WriteLine("BINARY SEARCH TREE");
            Console.WriteLine("Searching for 100...");
            Console.WriteLine($"Found: {binaryTree.Search(root2, 100).Value}");

            Console.WriteLine("\nSearching for 75...");
            Console.WriteLine($"Found: {binaryTree.Search(root2, 75).Value}");

            Console.WriteLine("\nAdding 75 to the tree...");
            binaryTree.Add(root2, 75);
            Console.WriteLine($"Success! Added {binaryTree.Search(root2, 75).Value}");
        }
    }
}
