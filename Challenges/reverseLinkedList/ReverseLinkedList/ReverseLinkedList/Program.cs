using System;
using LinkedLists.Classes;

namespace ReverseLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node("A");
            Node node2 = new Node("B");
            Node node3 = new Node("C");
            Node node4 = new Node("D");
            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);

            Console.WriteLine("Original Linked List:");
            list.Print();

            Console.WriteLine("\nReversed Linked List:");
            ReverseLL(list).Print();
        }

        /// <summary>
        /// Reverses a linked list in place
        /// </summary>
        /// <param name="list">linked list to be reversed</param>
        /// <returns>returns the linked list after being reversed</returns>
        public static LinkdList ReverseLL(LinkdList list)
        {
            Node prev = null;
            Node curr = list.Head;
            Node next = curr.Next;

            if (curr == null)
            {
                return list;
            }

            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            list.Head = prev;

            return list;
        }
    }
}