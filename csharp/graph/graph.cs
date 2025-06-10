namespace csharp.graph;

public class Graph
{
    
}

public class Node
{
    public string Name; 
    public List<Node> Neighbors { get; set; }

    public Node(string name)
    {
        Name = name;
        Neighbors = new List<Node>();
    }
}