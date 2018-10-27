using System;
using System.Collections.Generic;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node6 = new Node(60, null, null);
            Node node5 = new Node(50, null, null);
            Node node4 = new Node(40, null, null);
            Node node3 = new Node(30, null, null);
            Node node2 = new Node(20, node5, node6);
            Node node1 = new Node(10, node3, node4);
            Node root = new Node(0, node1, node2);
            BinaryTree tree = new BinaryTree(root);

            List<Node> pre = tree.PreOrder(root);

            foreach(Node item in pre)
            {
                Console.WriteLine(item.Value);
            }
            pre.RemoveAll(item => item is Node);
        }
    }
}
