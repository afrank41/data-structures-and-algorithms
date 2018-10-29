using System;
using System.Collections.Generic;
using Tree.Classes;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node6 = new Node(20, null, null);
            Node node5 = new Node(12, null, null);
            Node node4 = new Node(30, null, null);
            Node node3 = new Node(7, null, null);
            Node node2 = new Node(5, node5, node6);
            Node node1 = new Node(3, node3, node4);
            Node root = new Node(15, node1, node2);

            FizzBuzzTree(root);
        }

        /// <summary>
        /// Traverses a tree and judges if node value fizz, buzz, or fizzbuzz
        /// </summary>
        /// <param name="root">root node of binary tree to be traversed</param>
        /// <returns>eturns a list of fizzbuzz strings</returns>
        public static List<string> FizzBuzzTree(Node root)
        {
            List<string> list = new List<string>();
            BinaryTree tree = new BinaryTree(root);

            foreach (Node item in tree.PreOrder(root))
            {
                if (item.Value % 15 == 0)
                {
                    list.Add("FizzBuzz");
                    Console.WriteLine($"{item.Value} = FizzBuzz");
                }
                else if (item.Value % 3 == 0)
                {
                    list.Add("Fizz");
                    Console.WriteLine($"{item.Value} = Fizz");
                }
                else if (item.Value % 5 == 0)
                {
                    list.Add("Buzz");
                    Console.WriteLine($"{item.Value} = Buzz");
                }
                else
                {
                    list.Add($"{item.Value}");
                    Console.WriteLine($"{item.Value} is NOT FizzBuzz");
                }
            }

            return list;
        }
    }
}
