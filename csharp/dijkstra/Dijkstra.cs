using csharp.graph;

namespace csharp.dijkstra;

public class Dijkstra
{
    //initailiser mes noeuds et leur distance
    public static Dictionary<Node, int> distances = new();
    
    // on boucle pour chaque distances 
    public static void Compute(Graph graph, Node start)
    {
        foreach (var node in graph.Nodes )
        {
            distances[node] = int.MaxValue;
        }
    }
}