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
        /// Big O: O(1)
        /// </summary>
        /// <param name="node">Node to be inserted at beginning of LL as new HEAD</param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }
    }
}
