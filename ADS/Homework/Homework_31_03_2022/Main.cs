/*using System;
namespace ADS.Homework.Homework_31_03_2022;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("f");
        int vertexCount = int.Parse(Console.ReadLine());
        int edgesCount = int.Parse(Console.ReadLine());
        Graph graph = new Graph(vertexCount, edgesCount);

        for (int i = 0; i < edgesCount; i++)
        {
            var edge = Console.ReadLine().Split(" ");
            graph.edge[i] = new Edge(Int32.Parse(edge[0]), Int32.Parse(edge[1]), Int32.Parse(edge[2]));
        }
        
        BellmanFordAlgorithm.BellmanFord(graph,0);
    }
}*/