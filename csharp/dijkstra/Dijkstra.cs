using csharp.graph;

namespace csharp.dijkstra;

public class Dijkstra
{
    //initailiser mes noeuds et leur distance
    public static Dictionary<Node, int> distances = new();
    
    // on boucle pour chaque distances 
    public static void Compute(Graph graph, Node start)
    {
        var unvisited = new HashSet<Node>(graph.Nodes);
        foreach (var node in graph.Nodes )
        {
            distances[node] = int.MaxValue;
        }
        
        distances[start] = 0;
        Node current = null;
        int minDistance = int.MaxValue;
  
}