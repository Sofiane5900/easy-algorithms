namespace csharp.graph;

public class Graph
{
}

public class Node
{
    public string Name; 
    public List<Node> Neighbors { get; set; }
}