using System;
using StackQueue.Classes;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nodes
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);

            // Stack
            Stack stack = new Stack(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.Push(node4);
            stack.Push(node5);

            Console.WriteLine("Node order in a stack:");
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

            // Queue
            Queue queue = new Queue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);

            Console.WriteLine("\nNode order in a queue:");
            Console.WriteLine(queue.Peek().Value);
            queue.Dequeue();
            Console.WriteLine(queue.Peek().Value);
            queue.Dequeue();
            Console.WriteLine(queue.Peek().Value);
            queue.Dequeue();
            Console.WriteLine(queue.Peek().Value);
            queue.Dequeue();
            Console.WriteLine(queue.Peek().Value);
            queue.Dequeue();
        }
    }
}
