using Hashtables.Classes;
using System;

namespace MostCommonWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "no repeated words here sir";
            Console.WriteLine($"Input string: {input}\n");

            Console.WriteLine($"Most common word: {MostCommonWord(input)}");
        }

        public static string MostCommonWord(string input)
        {
            string[] words = input.ToLower().Split(" ");
            HashTable ht = new HashTable();

            int count = 0;
            string result = "";

            foreach(string word in words)
            {
                if (!ht.Contains(word))
                {
                    ht.Add(word, 1);
                }
                else if (ht.Contains(word))
                {
                    int index = ht.GetHash(word);
                    ht.Table[index].Head.Value = (int)ht.Table[index].Head.Value + 1;
                    int value = (int)ht.Table[index].Head.Value;

                    if (value > count)
                    {
                        count = value;
                        result = word;
                    }
                }
            }

            if (result == "")
            {
                result = "No repeated words";
            }

            return result;
        }
    }
}
