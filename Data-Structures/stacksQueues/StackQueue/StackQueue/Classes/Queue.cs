using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        
        public Node Rear { get; set; }

        /// <summary>
        /// Looks at the Front node in a queue
        /// </summary>
        /// <returns>returns the node that was looked at</returns>
        public Node Peek()
        {
            return Front;
        }

        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }
    }
}
