using System;
using StackQueue.Classes;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);

            Stack stack = new Stack(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.Push(node4);
            stack.Push(node5);

            Console.WriteLine("Nodes in my stack:");
            Console.WriteLine(stack.Peek().Value);
            stack.Pop();
            Console.WriteLine(stack.Peek().Value);
            stack.Pop();
            Console.WriteLine(stack.Peek().Value);
            stack.Pop();
            Console.WriteLine(stack.Peek().Value);
            stack.Pop();
            Console.WriteLine(stack.Peek().Value);
            stack.Pop();
        }
    }
}
