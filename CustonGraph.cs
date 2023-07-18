using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccustomgraph
{
    internal class CustonGraph
    {
        private Dictionary<string, List<string>> graph;
        public CustonGraph()
        {
            graph = new Dictionary<string, List<string>>();
        }
        public void AddVertex(string vertex)
        {
            if (!graph.ContainsKey(vertex))
            {
                graph[vertex] = new List<string>();
            }
        }

        public void AddEdge(string vertex1,string vertix2)
        {
            if (graph.ContainsKey(vertex1)& graph.ContainsKey(vertix2))
            {
                graph[vertex1].Add(vertix2);
                graph[vertix2].Add(vertex1 );
            }
        }

        public List<string> GetNighboors(string vertexe)
        {
            if (graph.ContainsKey(vertexe))
            {
                return graph[vertexe];
            }
            return null;
        }

        public Dictionary<string,List<string>> PrintGraph()
        {
            return graph;
        }
        public void DFS(string startvortex)
        {
            HashSet<string> visited = new HashSet<string>();//keep trak with the visited node
            DFSrecursive(startvortex, visited);
        }
        public void DFSrecursive(string currentvortex, HashSet<string> visited)
        {
            visited.Add(currentvortex);
            Console.WriteLine(currentvortex + " ");
            foreach (string Vertex in graph[currentvortex])
            {
                if (!visited.Contains(Vertex))
                {
                    DFSrecursive(Vertex, visited);
                }
            }
        }
        public void DFSWithStack(string startvortex)
        {
            HashSet<string> visited = new HashSet<string>();//keep trak with the visited node
            Stack<string> stack = new Stack<string>();

            stack.Push(startvortex);
            while (stack.Count > 0)
            {
                string currentVertex = stack.Pop();
                if (!visited.Contains(currentVertex))
                {
                    Console.WriteLine(currentVertex + " ");
                    visited.Add(currentVertex);
                }
                foreach(String nightberVertex in graph[currentVertex])
                {
                    if (!visited.Contains(nightberVertex))
                    {
                        stack.Push(nightberVertex);
                    }
                }
            }
        }

    }
}
