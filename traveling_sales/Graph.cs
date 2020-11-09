using System.Collections.Generic;
using System;

namespace traveling_sales
{
    public class Vertex
    {
        public Vertex()
        {
            this.neighbors = new List<Edge>();
        }
        public int index { get; set; }
        public double data { get; set; }
        public List<Edge> neighbors { get; set; } // lista wszystkich sąsiadów którzy są obok (niezależnie od kierunku krawędzi)
        public List<Edge> DaWey { get; set; } // lista gdzie możemy iść
        public float x { get; set; }
        public float y { get; set; }
    }

    public class Edge
    {
        public Edge()
        {
            this.vertex1 = new Vertex();
            this.vertex2 = new Vertex();
        }
        public int distance { get; set; }
        //public bool onesided {get; set}
        //public double pheromoneValue { get; set; }
        public Vertex vertex1 { get; set; }
        public Vertex vertex2 { get; set; }
        //public float Lenght { get => lenght; set => lenght = value; }

        //private float lenght = Math.Sqrt(Math.Pow(vertex2.x - vertex1.x, 2.0) + Math.Pow(vertex2.y - vertex1.y, 2.0));
    }

    public class Graph
    {
        public Graph()
        {
            this.vertices = new List<Vertex>();
            this.edges = new List<Edge>();
        }
        public List<Vertex> vertices { get; set; }
        public List<Edge> edges { get; set; }
    }
}