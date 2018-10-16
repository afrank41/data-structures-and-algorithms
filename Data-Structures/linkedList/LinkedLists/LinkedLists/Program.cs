using System;
using LinkedLists.Classes;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Node node1 = new Node(7);
            Node node2 = new Node("cat");
            Node node3 = new Node("dog");
            Node node4 = new Node(14);
            Node node5 = new Node("bird");

            LinkdList list = new LinkdList(node1);
            list.Add(node2);
            list.Append(node3);
            list.AddBefore(node4, node1);
            list.AddAfter(node5, node3);
            list.Print();
            object searchTerm = 14;
            Node foundNode = list.Find(searchTerm);
            Console.WriteLine($"You searched for {searchTerm} and found {foundNode.Value}");
        }
    }
}
