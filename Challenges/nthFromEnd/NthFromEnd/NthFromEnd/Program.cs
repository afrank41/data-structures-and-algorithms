using System;
using NthFromEnd.Classes;

namespace NthFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);
            LinkedList list = new LinkedList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);
            list.Append(node5);


        }
    }
}
