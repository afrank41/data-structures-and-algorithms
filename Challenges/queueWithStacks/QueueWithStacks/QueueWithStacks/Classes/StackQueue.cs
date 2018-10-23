using System;
using System.Collections.Generic;
using System.Text;
using StackQueue.Classes;

namespace QueueWithStacks.Classes
{
    public class Cue
    {
        Stack stack1 = new Stack(null);
        Stack stack2 = new Stack(null);

        public Stack Stack1 { get; set; }

        public Stack Stack2 { get; set; }

        public Cue(Stack stackOne, Stack stackTwo)
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
            if (Stack2.Peek() == null)
            {
                return null;
            }

            while(Stack2.Peek().Next != null)
            {
                Stack1.Push(Stack2.Pop());
            }

            Node temp = Stack2.Pop();

            while (Stack1.Peek() != null)
            {
                Stack2.Push(Stack1.Pop());
            }

            return temp;
        }
    }
}
