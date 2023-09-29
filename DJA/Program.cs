using System;
using System.Collections.Generic;

public class Graph
{
    private int vertices;
    private List<KeyValuePair<int, int>>[] adj;

    // Constructor for graph
    public Graph(int vertices)
    {
        this.vertices = vertices;
        InitializeAdjacencyList(vertices);
    }

    // Initialize adjacency list
    private void InitializeAdjacencyList(int vertices)
    {
        adj = new List<KeyValuePair<int, int>>[vertices];

        for (int i = 0; i < vertices; ++i)
            adj[i] = new List<KeyValuePair<int, int>>();
    }

    // Method to add an edge into the graph
    public void AddEdge(int u, int v, int weight)
    {
        adj[u].Add(new KeyValuePair<int, int>(v, weight));
        adj[v].Add(new KeyValuePair<int, int>(u, weight));
    }

    // A utility function to find the vertex with minimum distance value
    public void Dijkstra(int src)
    {
        PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
        int[] dist = new int[vertices];

        InitializeDistances(dist);
        
        priorityQueue.Enqueue(src, 0);
        dist[src] = 0;

        while (priorityQueue.Count() > 0) 
            
        {
            int u = priorityQueue.Dequeue();
            int b = priorityQueue.GetHashCode(GetHashCode)
            
            foreach (KeyValuePair<int, int> i in adj[u])
            {
                int v = i.Key;
                int weight = i.Value;

                if (dist[v] > dist[u] + weight)
                {
                    dist[v] = dist[u] + weight;

                    priorityQueue.Enqueue(v, dist[v]);
                }
            }
        }
        PrintSolution(dist);
    }

    // Initialize distances to maximum value
    private void InitializeDistances(int[] dist)
    {
        for (int i = 0; i < vertices; i++)
            dist[i] = int.MaxValue;
    }
    
    // A utility function to print the constructed distance array
    private void PrintSolution(int[] dist)
    {
        Console.WriteLine("Vertex distance from source");

        for (int i = 0; i < vertices; ++i)
            Console.WriteLine(i + " \t\t " + dist[i]);
    }
}

public class PriorityQueue<T>
{
    private List<KeyValuePair<T, int>> list;

    public PriorityQueue()
    {
        list = new List<KeyValuePair<T, int>>();
    }

    // Adds an item to the priority queue
    public void Enqueue(T item, int priority)
    {
        list.Add(new KeyValuePair<T, int>(item, priority));
        list.Sort((x, y) => x.Value.CompareTo(y.Value));
    }

    // Removes and returns the item with the highest priority
    public T Dequeue()
    {
        T item = list[0].Key;
        list.RemoveAt(0);
        return item;
    }

    // Returns the count of items in the priority queue
    public int Count()
    {
        return list.Count;
    }
}

public class Program
{
    public static void Main()
    {
        Graph graph = CreateGraph();

        // Compute shortest paths from vertex 0
        graph.Dijkstra(0);
    }

    // Creates a graph and returns it
    private static Graph CreateGraph()
    {
        Graph graph = new Graph(9);

        graph.AddEdge(0, 1, 4);
        graph.AddEdge(0, 7, 8);
        graph.AddEdge(1, 2, 8);
        graph.AddEdge(1, 7, 11);
        graph.AddEdge(2, 3, 7);
        graph.AddEdge(2, 8, 2);
        graph.AddEdge(2, 5, 4);
        graph.AddEdge(3, 4, 9);
        graph.AddEdge(3, 5, 14);
        graph.AddEdge(4, 5, 10);
        graph.AddEdge(5, 6, 2);
        graph.AddEdge(6, 7, 1);
        graph.AddEdge(6, 8, 6);
        graph.AddEdge(7, 8, 7);

        return graph;
    }
}
