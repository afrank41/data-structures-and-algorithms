using Graphs.Classes;
using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Tuple<Node, int>> node1 = new LinkedList<Tuple<Node, int>>();
            LinkedList<Tuple<Node, int>> node2 = new LinkedList<Tuple<Node, int>>();
            LinkedList<Tuple<Node, int>> node3 = new LinkedList<Tuple<Node, int>>();

            Graph graph = new Graph();
            graph.AdjacenyList.AddLast(node1);
            graph.AdjacenyList.AddLast(node2);
            graph.AdjacenyList.AddLast(node3);
        }
    }
}
