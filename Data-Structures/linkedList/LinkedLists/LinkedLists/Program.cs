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

            LinkedList list = new LinkedList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);
            list.Print();
            object searchTerm = "dog";
            Node foundNode = list.Find(searchTerm);
            Console.WriteLine($"You searched for {searchTerm} and found {foundNode.Value}");
        }
    }
}
