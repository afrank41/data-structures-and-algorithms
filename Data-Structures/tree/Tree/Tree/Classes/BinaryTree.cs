using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node root)
        {
            Root = root;
        }

        List<Node> preOrderlist = new List<Node>();
        public List<Node> PreOrder(Node root)
        {
            preOrderlist.Add(root);

            if (root.Left != null)
            {
                PreOrder(root.Left);
            }

            if (root.Right != null)
            {
                PreOrder(root.Right);
            }

            return preOrderlist;
        }
    }
}
