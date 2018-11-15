using Hashtables.Classes;
using System;

namespace RepeatWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = "The quick brown fox jumps over the fence";
            string s2 = "This sentence sucks because no words repeat";

            Console.WriteLine(s1);
            Console.WriteLine($"First word repeated: {RepeatedWord(s1)}\n");

            Console.WriteLine(s2);
            Console.WriteLine($"First word repeated: {RepeatedWord(s2)}");
        }

        public static string RepeatedWord(string input)
        {
            string[] temp = input.ToLower().Split(" ");
            HashTable table = new HashTable();

            foreach (string word in temp)
            {
                if (!table.Contains(word))
                {
                    table.Add(word, word);
                } 
                else
                {
                    return word;
                }
            }

            return "No Repeated Word";
        }
    }
}
