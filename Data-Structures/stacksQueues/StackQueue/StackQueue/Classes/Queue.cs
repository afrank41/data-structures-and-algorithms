using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Looks at the Front node in a queue
        /// </summary>
        /// <returns>returns the node that was looked at</returns>
        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// Adds a new node to the rear of a queue
        /// </summary>
        /// <param name="node">node to be added to the rear</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Removes the Front node from a queue
        /// </summary>
        /// <returns>returns the node that was removed</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
