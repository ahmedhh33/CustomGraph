namespace basiccustomgraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustonGraph graph = new CustonGraph();
            // add vertices
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            graph.AddVertex("E");
            graph.AddVertex("F");

            // add edges
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("C", "D");
            graph.AddEdge("D", "A");
            graph.AddEdge("A", "E");
            graph.AddEdge("E", "F");

            List<string> nighboors = graph.GetNighboors("A");
            Console.WriteLine($"Nightboors of A: {string.Join(", ", nighboors)}");

            //print the graph
            Dictionary<string, List<string>> graphStructure = graph.PrintGraph();
            foreach(var vertax in graphStructure)
            {
                Console.WriteLine("vertex: " + vertax.Key);
                Console.WriteLine($"Nightboors: {string.Join(", ", vertax.Value)}");
            }
            Console.WriteLine("Tavesal using stack for DFS");
            graph.DFSWithStack("A");
            Console.WriteLine("Tavesal using recursiv for DFS");
            graph.DFS("A");
        }
    }
}