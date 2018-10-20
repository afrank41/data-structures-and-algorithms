using System;
using Xunit;
using LinkedLists.Classes;
using static PalindromeLL.Program;

namespace PalindromeLLTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Checks to see if an even lengthed LL is a palindrome
        /// </summary>
        [Fact]
        public void CanTestIfListLengthIsEven()
        {
            Node node1 = new Node("A");
            Node node2 = new Node("N");
            Node node3 = new Node("N");
            Node node4 = new Node("A");
            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);

            Assert.True(PalindromeCheck(list));
        }

        /// <summary>
        /// Checks to see if an odd lengthed LL is a palindrome
        /// Fun Fact: Aibohphobia is the fear of palindromes
        /// </summary>
        [Fact]
        public void CanTestIfListLengthIsOdd()
        {
            Node node1 = new Node("A");
            Node node2 = new Node("I");
            Node node3 = new Node("B");
            Node node4 = new Node("O");
            Node node5 = new Node("H");
            Node node6 = new Node("P");
            Node node7 = new Node("H");
            Node node8 = new Node("O");
            Node node9 = new Node("B");
            Node node10 = new Node("I");
            Node node11 = new Node("A");
            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);
            list.Append(node5);
            list.Append(node6);
            list.Append(node7);
            list.Append(node8);
            list.Append(node9);
            list.Append(node10);
            list.Append(node11);

            Assert.True(PalindromeCheck(list));
        }

        /// <summary>
        /// Checks to see if a LL is not a palindrome
        /// </summary>
        [Fact]
        public void ReturnsFalseIfLLIsNotPalindrome()
        {
            Node node1 = new Node("A");
            Node node2 = new Node("B");
            Node node3 = new Node("C");
            Node node4 = new Node("D");
            LinkdList list = new LinkdList(node1);
            list.Append(node2);
            list.Append(node3);
            list.Append(node4);

            Assert.False(PalindromeCheck(list));

        }       
    }
}
