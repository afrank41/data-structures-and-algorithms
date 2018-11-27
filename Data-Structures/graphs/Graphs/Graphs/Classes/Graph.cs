using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classes
{
    class Graph
    {
        public LinkedList<LinkedList<Tuple<Node, int>>> AdjacenyList { get; set; }

        public Graph()
        {
            AdjacenyList = new LinkedList<LinkedList<Tuple<Node, int>>>();
        }

        public void AddEdge(LinkedList<Tuple<Node, int>> parent, Tuple<Node, int> child)
        {
            if (AdjacenyList.Contains(parent))
            {
                parent.AddLast(child);
            }
            else
            {
                AdjacenyList.AddLast(parent);
                parent.AddLast(child);
            }
        }

        public List<Tuple<Node, int>> GetNeighbors(LinkedList<Tuple<Node, int>> parent)
        {
            List<Tuple<Node, int>> list = new List<Tuple<Node, int>>();

            foreach (Tuple<Node, int> item in parent)
            {
                list.Add(item);
            }

            return list;
        }

        public List<LinkedList<Tuple<Node, int>>> GetNodes()
        {
            List<LinkedList<Tuple<Node, int>>> list = new List<LinkedList<Tuple<Node, int>>>();

            foreach (LinkedList<Tuple<Node, int>> item in AdjacenyList)
            {
                list.Add(item);
            }

            return list;
        }

        public int Size()
        {
            return AdjacenyList.Count;
        }
    }
}
