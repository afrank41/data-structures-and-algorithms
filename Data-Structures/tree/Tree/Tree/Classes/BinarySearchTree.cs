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

        /// <summary>
        /// Search for a specific node in a binary search tree
        /// </summary>
        /// <param name="root">root of the tree being traversed</param>
        /// <param name="value">value to be searched for in node</param>
        /// <returns>returns node if found or a node with -1 value if not found</returns>
        public Node Search(Node root, int value)
        {
            Node current = root;
            while (current != null)
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

        /// <summary>
        /// Add a new node to the correct spot in a binary tree
        /// </summary>
        /// <param name="root">the root of the tree being added to</param>
        /// <param name="value">value of the new node being added to the tree</param>
        public void Add(Node root, int value)
        {
            Node current = root;
            while (true)
            {
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node(value, null, null);
                        break;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else if (value > current.Value)
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node(value, null, null);
                        break;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }
    }
}
