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

            ReverseLL(list).Print();
        }

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