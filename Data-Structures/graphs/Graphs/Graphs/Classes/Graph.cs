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

        public void AddEdge(Node parent, Tuple<Node, int> child)
        {
            foreach (var item in AdjacenyList)
            {
                var node = item.First.Value.Item1;
                var tuple = item.First.Value.Item2;
            }
        }

        public void AddEdge(Node parent)
        {

        }
    }
}
