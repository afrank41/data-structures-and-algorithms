using System;
using System.Collections.Generic;
using Tree.Classes;

namespace BreadthFirstTraversal
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

            Console.WriteLine("Breadth First Traversal:");
            BreadthFirst(root);
        }

        static void BreadthFirst(Node root)
        {
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node front = queue.Dequeue();
                Console.WriteLine(front.Value);

                if (front.Left != null)
                {
                    queue.Enqueue(front.Left);
                }

                if (front.Right != null)
                {
                    queue.Enqueue(front.Right);
                }
            }
        }
    }
}
