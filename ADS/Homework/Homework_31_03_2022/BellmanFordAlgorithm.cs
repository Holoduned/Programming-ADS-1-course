namespace ADS.Homework.Homework_31_03_2022;

public struct Edge
{
    public int vertex1, vertex2;
    public int weight;

    public Edge(int v1, int v2, int Weight)
    {
        vertex1 = v1;
        vertex2 = v2;
        weight = Weight;
    }
}

public struct Graph
{
    public int VertexCount;
    public int EdgesCount;
    public Edge[] edge;
    
    public Graph(int vertexCount, int edgesCount)
    {
        VertexCount= vertexCount;
        EdgesCount = edgesCount;
        edge = new Edge[EdgesCount];
    }
}
public class BellmanFordAlgorithm
{
    public static void BellmanFord(Graph graph, int vertex)
    {
        int verticesCount = graph.VertexCount;
        int edgesCount = graph.EdgesCount;
        int[] distance = new int[verticesCount];

        for (int i = 0; i < verticesCount; i++)
        {
            distance[i] = int.MaxValue;
        }

        distance[vertex] = 0;

        for (int i = 1; i <= verticesCount - 1; ++i)
        {
            for (int j = 0; j < edgesCount; ++j)
            {
                int u = graph.edge[j].vertex1;
                int v = graph.edge[j].vertex2;
                int weight = graph.edge[j].weight;

                if (distance[u - 1] != int.MaxValue && distance[u - 1] + weight < distance[v - 1])
                {
                    distance[v - 1] = distance[u - 1] + weight;
                }
            }
        }
        Print(distance, verticesCount);
    }
    
    private static void Print(int[] distance, int count)
    {
        Console.WriteLine("Расстояние до вершины от источника");

        for (int i = 0; i < count; ++i)
            Console.WriteLine($"{i} {distance[i]}");
    }
}

