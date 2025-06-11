namespace csharp.graph;

public class Graph
{
    public List<Node> Nodes { get; set; }

    public Graph()
    {
        Nodes = new List<Node>();
    }
}

public class Node
{
    public string Name;
    public List<Edge> Neighbors { get; set; }

    public Node(string name, int km)
    {
        
        Name = name;
        Neighbors = new List<Edge>();
    }
}

public class Edge
{
    public Node Target { get; set; }
    public int Kilometer { get; set; }
}