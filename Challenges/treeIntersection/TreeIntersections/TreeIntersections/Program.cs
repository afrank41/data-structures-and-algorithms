using Hashtables.Classes;
using System;
using System.Collections.Generic;
using Tree.Classes;

namespace TreeIntersections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node6 = new Node(6, null, null);
            Node node5 = new Node(5, null, null);
            Node node4 = new Node(4, null, null);
            Node node3 = new Node(3, null, null);
            Node node2 = new Node(2, node5, node6);
            Node node1 = new Node(1, node3, node4);
            Node root1 = new Node(0, node1, node2);
            BinaryTree tree1 = new BinaryTree(root1);

            Node node7 = new Node(16, null, null);
            Node node8 = new Node(15, null, null);
            Node node9 = new Node(14, null, null);
            Node node10 = new Node(3, null, null);
            Node node11 = new Node(2, node7, node8);
            Node node12 = new Node(1, node9, node10);
            Node root2 = new Node(10, node11, node12);
            BinaryTree tree2 = new BinaryTree(root2);

            foreach (int num in TreeIntersection(tree1, tree2))
            {
                Console.WriteLine(num);
            }
        }

        static public List<int> TreeIntersection(BinaryTree bt1, BinaryTree bt2)
        {
            List<int> result = new List<int>();
            HashTable table = new HashTable();

            foreach (Node node in bt1.InOrder(bt1.Root))
            {
                table.Add(node.Value.ToString(), node.Value);
            }

            foreach (Node node in bt2.InOrder(bt2.Root))
            {
                if (table.Contains(node.Value.ToString()))
                {
                    result.Add(node.Value);
                }
            }

            return result;
        }
    }
}
