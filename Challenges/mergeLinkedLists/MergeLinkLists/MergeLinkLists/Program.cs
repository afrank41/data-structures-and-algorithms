using System;
using LinkedLists.Classes;

namespace MergeLinkLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);
            LinkdList LL1 = new LinkdList(node1);
            LL1.Append(node2);
            LL1.Append(node3);
            LL1.Append(node4);
            LL1.Append(node5);

            Node node6 = new Node(60);
            Node node7 = new Node(70);
            Node node8 = new Node(80);
            Node node9 = new Node(90);
            Node node10 = new Node(100);
            Node node11 = new Node(110);
            Node node12 = new Node(120);
            LinkdList LL2 = new LinkdList(node6);
            LL2.Append(node7);
            LL2.Append(node8);
            LL2.Append(node9);
            LL2.Append(node10);
            LL2.Append(node11);
            LL2.Append(node12);

            Console.WriteLine("Linked List 1:");
            LL1.Print();

            Console.WriteLine("\nLinked List 2:");
            LL2.Print();

            Console.WriteLine("\nMerged Link Lists:");
            MergeLists(LL1, LL2);
            LL1.Print();
        }

        /// <summary>
        /// Merge two link lists by zippering them together. Every other node will be a node from the second given LL
        /// </summary>
        /// <param name="LL1">The LL that will be traversed and operated on</param>
        /// <param name="LL2">The LL that will be zippered into the first LL</param>
        /// <returns>returns the head node of the merged LL</returns>
        public static Node MergeLists(LinkdList LL1, LinkdList LL2)
        {
            Node temp = LL2.Head.Next;
            LL1.Current = LL1.Head;

            while (LL1.Current.Next.Next != null)
            {
                LL1.AddAfter(LL2.Head, LL1.Current);
                if (temp == null)
                {
                    break;
                }
                LL2.Head = temp;
                temp = LL2.Head.Next;
                LL1.Current = LL1.Current.Next.Next;
            }

            LL1.AddAfter(LL2.Head, LL1.Current);
            LL2.Head = temp;
            LL1.Append(LL2.Head);
            LL2.Head = null;

            return LL1.Head;
        }        
    }
}
