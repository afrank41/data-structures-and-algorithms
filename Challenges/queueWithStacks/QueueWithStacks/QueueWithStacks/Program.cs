using System;
using QueueWithStacks.Classes;
using StackQueue.Classes;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack1 = new Stack(null);
            Stack stack2 = new Stack(null);
            Cue queue = new Cue(stack1, stack2);

            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);

            Console.WriteLine("Order of queue:");
            Console.WriteLine(queue.Dequeue().Value);
            Console.WriteLine(queue.Dequeue().Value);
            Console.WriteLine(queue.Dequeue().Value);
            Console.WriteLine(queue.Dequeue().Value);
            Console.WriteLine(queue.Dequeue().Value);
        }
    }
}
