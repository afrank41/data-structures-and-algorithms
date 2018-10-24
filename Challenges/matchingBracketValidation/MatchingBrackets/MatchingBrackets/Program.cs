using StackQueue.Classes;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchingBrackets
{
    class Program
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

        public static bool MatchingBracketValidation(string input)
        {
            Stack stack = new Stack(null);
            Regex open = new Regex(@"[(\[{]");
            Regex letter = new Regex(@"[A-Za-z]");

            for (int i = 0; i < input.Length; i++)
            {
                Match openMatch = open.Match(input[i].ToString());
                Match letterMatch = letter.Match(input[i].ToString());

                if (letterMatch.Success)
                {
                    continue;
                }
                else if (stack.Count == 0 || openMatch.Success)
                {
                    stack.Push(new Node(input[i].ToString()));
                }
                else if (stack.Count > 0 && !(openMatch.Success))
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
                        default:
                            stack.Push(temp);
                            break;
                    }
                }
            }

            return stack.Top == null;
        }
    }
}
