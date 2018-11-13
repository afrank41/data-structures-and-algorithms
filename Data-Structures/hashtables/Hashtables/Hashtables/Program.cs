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

            Console.WriteLine($"Added {table.Find("cat")}, {table.Find("dog")}, and {table.Find("bird")} to the table\n");

            Console.WriteLine($"Forcing a collision at index {table.GetHash("god")} in the hash table\n");
            table.Add("god", "puppy");
            Console.WriteLine($"The key of \"god\" with value of \"puppy\" collided at index {table.GetHash("god")}\n");

            Console.WriteLine($"Hashtable contains \"cat\": {table.Contains("cat")}");
            Console.WriteLine($"Hashtable contains \"dog\": {table.Contains("dog")}");
            Console.WriteLine($"Hashtable contains \"bird\": {table.Contains("bird")}");
            Console.WriteLine($"Hashtable contains \"god\": {table.Contains("god")}");
        }
    }
}
