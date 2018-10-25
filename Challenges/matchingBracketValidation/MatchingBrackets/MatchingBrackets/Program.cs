using StackQueue.Classes;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchingBrackets
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"()([])\"");
            Console.WriteLine($"Balanced Brackets: {MatchingBracketValidation("()([])")}\n");

            Console.WriteLine("\"ABCDEFG\"");
            Console.WriteLine($"Balanced Brackets: {MatchingBracketValidation("ABCDEFG")}\n");

            Console.WriteLine("\"({)}\"");
            Console.WriteLine($"Balanced Brackets: {MatchingBracketValidation("({)}")}\n");

            Console.WriteLine("\"HIGUYS(})\"");
            Console.WriteLine($"Balanced Brackets: {MatchingBracketValidation("HIGUYS(})")}\n");

            Console.WriteLine("\"]][]\"");
            Console.WriteLine($"Balanced Brackets: {MatchingBracketValidation("]][]")}\n");
        }

        /// <summary>
        /// Check if brackets are being opened and closed properly within a string
        /// </summary>
        /// <param name="input">string to be checked</param>
        /// <returns>return true if brackets open and close properly</returns>
        public static bool MatchingBracketValidation(string input)
        {
            Stack stack = new Stack(null);
            Regex openRegex = new Regex(@"[(\[{]");
            Regex symbolRegex = new Regex(@"[\w!?@#$%^&*-+=]");

            for (int i = 0; i < input.Length; i++)
            {
                Match open = openRegex.Match(input[i].ToString());
                Match symbol = symbolRegex.Match(input[i].ToString());

                if (symbol.Success)
                {
                    continue;
                }
                else if (stack.Count == 0 || open.Success)
                {
                    stack.Push(new Node(input[i].ToString()));
                }
                else if (stack.Count > 0 && !(open.Success))
                {
                    Node temp = stack.Pop();
                    switch (input[i].ToString())
                    {
                        case ")":
                            if (temp.Value.ToString() != "(") return false;
                            break;
                        case "]":
                            if (temp.Value.ToString() != "[") return false;
                            break;
                        case "}":
                            if (temp.Value.ToString() != "{") return false;
                            break;
                    }
                }
            }
            return stack.Top == null;
        }
    }
}
