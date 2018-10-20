using System;
using LinkedLists.Classes;

namespace PalindromeLL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node node1 = new Node("A");
            Node node2 = new Node("N");
            Node node3 = new Node("N");
            Node node4 = new Node("A");
            LinkdList list1 = new LinkdList(node1);
            list1.Append(node2);
            list1.Append(node3);
            list1.Append(node4);

            Console.WriteLine("First Linked List Test:");
            list1.Print();
            Console.WriteLine($"\nIs Palindrome: {PalindromeCheck(list1)}");

            Node node5 = new Node("A");
            Node node6 = new Node("B");
            Node node7 = new Node("C");
            Node node8 = new Node("D");
            LinkdList list2 = new LinkdList(node5);
            list2.Append(node6);
            list2.Append(node7);
            list2.Append(node8);

            Console.WriteLine("\nSecond Linked List Test:");
            list2.Print();
            Console.WriteLine($"\nIs Palindrome: {PalindromeCheck(list2)}");

            Console.WriteLine(7 / 2);
        }

        public static bool PalindromeCheck(LinkdList list)
        {
            list.Current = list.Head;

            string test = "";

            while (list.Current != null)
            {
                test = test + list.Current.Value;
                list.Current = list.Current.Next;
            }

            for (int i = 0; i < test.Length / 2; i++)
            {
                if(test[i] != test[test.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
