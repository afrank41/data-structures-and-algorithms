using Hashtables.Classes;
using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable table = new HashTable();
            table.Add("cat", "cat");
            table.Add("dog", "dog");
            table.Add("bird", "bird");

            Console.WriteLine(table.Find("puppy"));
        }
    }
}
