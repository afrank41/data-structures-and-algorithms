using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        public Node Search(Node root, int value)
        {
            Node current = root;
            while (current.Left != null && current.Right != null)
            {
                if (current.Value == value)
                {
                    return current;
                }
                else if (current.Value > value)
                {
                    current = current.Left;
                }
                else if (current.Value < value)
                {
                    current = current.Right;
                }
            }

            return new Node(-1, null, null);
        }
    }
}
