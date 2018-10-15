using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Classes
{
    class LinkedList
    {
        /// <summary>
        /// Always points to the first node in the LL
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// The node that is used to traverse through the LL
        /// </summary>
        public Node Current{ get; set; }

        /// <summary>
        /// LL requires a node at time of creation to the HEAD
        /// </summary>
        /// <param name="node">Node to be set as head of new LL</param>
        public LinkedList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Add node at the beginning of LL  
        /// Big O Time: O(1)
        /// Big O Space: O(1)
        /// </summary>
        /// <param name="node">Node to be inserted at beginning of LL as new HEAD</param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// We must traverse in order to print
        /// Big O Time: O(n)
        /// Big O Space: O(1)
        /// </summary>
        public void Print()
        {
            Current = Head;

            while(Current.Next != null)
            {
                Console.WriteLine($"{Current.Value} -->");
                Current = Current.Next;
            }

            Console.WriteLine($"{Current.Value} --> NULL");
            Current = Head;
        }

        /// <summary>
        /// We must traverse in order to append a new node to LL
        /// Big O Time: O(n)
        /// Big O Space: O(1)
        /// </summary>
        /// <param name="newNode">Node to be appended to LL</param>
        public void Append(Node newNode)
        {
            Current = Head;

            while(Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = newNode;
            Current = Head;
        }

        /// <summary>
        ///  We must traverse in order to add a new node to LL
        ///  Big O Time: O(n)
        ///  Big O Space: O(1)
        /// </summary>
        /// <param name="newNode">Node to be added to LL</param>
        /// <param name="existingNode">Node that is getting preceded by new node</param>
        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if(Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }

            while (Current.Next != null)
            {
                if(Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }

                Current = Current.Next;
            }
        }
    }
}
