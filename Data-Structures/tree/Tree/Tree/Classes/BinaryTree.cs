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
        List<Node> inOrderlist = new List<Node>();
        List<Node> postOrderlist = new List<Node>();

        /// <summary>
        /// Traverse a binary tree a return a list of nodes that are in the order of root, left, right
        /// </summary>
        /// <param name="root">root of the binary tree being traversed</param>
        /// <returns>returns the ordered list of nodes</returns>
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

        /// <summary>
        /// Traverse a binary tree a return a list of nodes that are in the order of left, root, right
        /// </summary>
        /// <param name="root">root of the binary tree being traversed</param>
        /// <returns>returns the ordered list of nodes</returns>
        public List<Node> InOrder(Node root)
        {

            if (root.Left != null)
            {
                InOrder(root.Left);
            }

            inOrderlist.Add(root);

            if (root.Right != null)
            {
                InOrder(root.Right);
            }

            return inOrderlist;
        }

        /// <summary>
        /// Traverse a binary tree a return a list of nodes that are in the order of left, right, root
        /// </summary>
        /// <param name="root">root of the binary tree being traversed</param>
        /// <returns>returns the ordered list of nodes</returns>
        public List<Node> PostOrder(Node root)
        {

            if (root.Left != null)
            {
                PostOrder(root.Left);
            }

            if (root.Right != null)
            {
                PostOrder(root.Right);
            }

            postOrderlist.Add(root);

            return postOrderlist;
        }
    }
}
