using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Looks at top node in a stack
        /// </summary>
        /// <returns>returns the top node of the stack</returns>
        public Node Peek()
        {
            return Top;
        }

        /// <summary>
        /// Remove top node in a stack from the stack
        /// </summary>
        /// <returns>returns the node that was removed</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;

            return temp;
        }

        /// <summary>
        /// Adds a node to the top of the stack
        /// </summary>
        /// <param name="node">node to be added to top of the stack</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
