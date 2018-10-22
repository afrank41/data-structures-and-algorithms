using System;
using System.Collections.Generic;
using System.Text;
using StackQueue.Classes;

namespace QueueWithStacks.Classes
{
    public class StackQueue
    {
        Stack stack1 = new Stack(null);
        Stack stack2 = new Stack(null);

        public Stack Stack1 { get; set; }

        public Stack Stack2 { get; set; }

        public StackQueue(Stack stack1, Stack stack2)
        {
            Stack1 = stack1;
            Stack2 = stack2;
        }

        /// <summary>
        /// Adds new node to front of queue by pushing node to top of stack2
        /// </summary>
        /// <param name="node">new node to be enqueued</param>
        public void Enqueue(Node node)
        {
            stack2.Push(node);
        }

        /// <summary>
        /// Removes a node from the queue
        /// </summary>
        /// <returns>returns the node that was dequeued</returns>
        public Node Dequeue()
        {
            while(stack2.Peek().Next != null)
            {
                stack1.Push(stack2.Pop());
            }

            Node temp = stack2.Pop();

            while (stack1.Peek() != null)
            {
                stack2.Push(stack1.Pop());
            }

            return temp;
        }
    }
}
