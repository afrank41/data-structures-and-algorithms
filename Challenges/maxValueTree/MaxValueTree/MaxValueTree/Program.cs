using System;
using Tree.Classes;

namespace MaxValueTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node6 = new Node(6, null, null);
            Node node5 = new Node(5, null, null);
            Node node4 = new Node(10, null, null);
            Node node3 = new Node(3, null, null);
            Node node2 = new Node(2, node5, node6);
            Node node1 = new Node(1, node3, node4);
            Node root = new Node(0, node1, node2);
            BinaryTree tree = new BinaryTree(root);

            Console.WriteLine("Max Value in Tree:");
            Console.WriteLine(MaxValue(tree));
        }

        static int MaxValue(BinaryTree tree)
        {
            int max = 0;

            foreach(Node item in tree.PreOrder(tree.Root))
            {
                if(item.Value > max)
                {
                    max = item.Value;
                }

            }

            return max;
        }
    }
}
