using csharp.graph;

namespace csharp.dijkstra;

public class Dijkstra
{
    public static Dictionary<Node, int> distances = new();

    public static void Compute(Graph graph, Node start)
    {
        var unvisited = new HashSet<Node>(graph.Nodes);
        foreach (var node in graph.Nodes)
        {
            distances[node] = int.MaxValue;
        }

        distances[start] = 0;
        Node current = null;
        int minDistance = int.MaxValue;
        while (unvisited.Count > 0)
        {
            foreach (var node in unvisited)
            {
                if (distances[node] < minDistance)
                {
                    minDistance = distances[node];
                    current = node;
                }
            }

            if (current == null)
                break;

            foreach (var edge in current.Neighbors)
            {
                var neighbor = edge.Target;
                int alt = distances[neighbor] + edge.Kilometer;
                if (alt < distances[neighbor])
                {
                    distances[neighbor] = alt;
                }
            }

            unvisited.Remove(current);
        }
    }
}
