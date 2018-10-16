using System;
using LinkedLists.Classes;

namespace NthFromEnd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(NthNodeFromEnd(0));
            Console.WriteLine(NthNodeFromEnd(4));
            Console.WriteLine(NthNodeFromEnd(2));
        }

        /// <summary>
        /// Finds the value of the nth node from the end of a LL
        /// </summary>
        /// <param name="n">nth number</param>
        /// <returns>returns the value of the nth node from the end of the LL</returns>
        public static object NthNodeFromEnd(int n)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);
            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);
            list.Append(node5);

            int counter = 0;

            list.Current = list.Head;
            while(list.Current.Next != null)
            {
                list.Current = list.Current.Next;
                counter++;
            }

            if(n < 0 || n > counter)
            {
                Exception ex = new Exception("Your input is bad");
                return ex.Message;
            }

            list.Current = list.Head;
            for (int i = 0; i < (counter - n); i++)
            {
                list.Current = list.Current.Next;
            }

            return list.Current.Value;
        }
    }
}
