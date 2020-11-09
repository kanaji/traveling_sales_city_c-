using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traveling_sales
{
    public static class GraphMethods
    {
        public static Graph CreateFullGraph()
        {

            // brak argumentów i losowości
            Graph graph = new Graph();

            int i = 0;
            
            foreach (Button buttons in )
            {
                Vertex vertex = new Vertex();
                vertex.index = i;
                i++;
                vertex.x = buttons.Location.X;
                vertex.y = buttons.Location.Y;
                graph.vertices.Add(vertex);
            }

            for (int i = 0; i < 15; i++)
            {
                Vertex vertex = new Vertex();
                vertex.index = i;
                graph.vertices.Add(vertex);
                //uzupełnienie x i y
            }

            for (int i = 0; i < 15; i++)
            {
                // Math.Sqrt(Math.Pow(vertex2.x - vertex1.x, 2.0) + Math.Pow(vertex2.y - vertex1.y, 2.0));
                if (i == 0)
                {
                    Edge edge1 = new Edge();
                    edge1.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i + 1].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i + 1].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    Edge edge2 = new Edge();
                    edge2.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i + 5].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i + 5].y - graph.vertices[i].y, 2.0))); //wzór dla i - i +5
                                                                                                                                                                             //edge.pheromoneValue = pheromoneValue;

                    edge1.vertex1 = graph.vertices[i];
                    edge1.vertex2 = graph.vertices[i + 1];
                    edge2.vertex1 = graph.vertices[i];
                    edge2.vertex2 = graph.vertices[i + 5];

                    //tworzenie DaWay
                    graph.vertices[i].neighbors.Add(edge1);
                    graph.vertices[i].neighbors.Add(edge2);

                    graph.edges.Add(edge1);
                    graph.edges.Add(edge2);
                }
                if (i > 0 && i < 4)
                {
                    Edge edge1 = new Edge();
                    edge1.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i + 1].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i + 1].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    Edge edge2 = new Edge();
                    edge2.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i + 5].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i + 5].y - graph.vertices[i].y, 2.0))); //wzór dla i - i +5
                                                                                                                                                                             //edge.pheromoneValue = pheromoneValue;

                    Edge edge3 = new Edge();
                    edge3.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i].x - graph.vertices[i - 1].x, 2.0) + Math.Pow(graph.vertices[i - 1].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    edge1.vertex1 = graph.vertices[i];
                    edge1.vertex2 = graph.vertices[i + 1];
                    edge2.vertex1 = graph.vertices[i];
                    edge2.vertex2 = graph.vertices[i + 5];
                    edge3.vertex1 = graph.vertices[i];
                    edge3.vertex2 = graph.vertices[i - 1];

                    //tworzenie DaWay
                    graph.vertices[i].neighbors.Add(edge1);
                    graph.vertices[i].neighbors.Add(edge2);
                    graph.vertices[i].neighbors.Add(edge3);

                    graph.edges.Add(edge1);
                    graph.edges.Add(edge2);
                    graph.edges.Add(edge3);
                }
                if (i == 4)
                {
                    Edge edge1 = new Edge();
                    edge1.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i - 1].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i - 1].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    Edge edge2 = new Edge();
                    edge2.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i + 5].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i + 5].y - graph.vertices[i].y, 2.0))); //wzór dla i - i +5
                                                                                                                                                                             //edge.pheromoneValue = pheromoneValue;

                    edge1.vertex1 = graph.vertices[i];
                    edge1.vertex2 = graph.vertices[i - 1];
                    edge2.vertex1 = graph.vertices[i];
                    edge2.vertex2 = graph.vertices[i + 5];

                    //tworzenie DaWay
                    graph.vertices[i].neighbors.Add(edge1);
                    graph.vertices[i].neighbors.Add(edge2);

                    graph.edges.Add(edge1);
                    graph.edges.Add(edge2);
                }
                if (i == 5)
                {
                    Edge edge1 = new Edge();
                    edge1.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i - 5].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i - 5].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    Edge edge2 = new Edge();
                    edge2.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i + 5].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i + 5].y - graph.vertices[i].y, 2.0))); //wzór dla i - i +5
                                                                                                                                                                             //edge.pheromoneValue = pheromoneValue;

                    Edge edge3 = new Edge();
                    edge3.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i].x - graph.vertices[i + 1].x, 2.0) + Math.Pow(graph.vertices[i + 1].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    edge1.vertex1 = graph.vertices[i];
                    edge1.vertex2 = graph.vertices[i - 5];
                    edge2.vertex1 = graph.vertices[i];
                    edge2.vertex2 = graph.vertices[i + 5];
                    edge3.vertex1 = graph.vertices[i];
                    edge3.vertex2 = graph.vertices[i + 1];

                    //tworzenie DaWay
                    graph.vertices[i].neighbors.Add(edge1);
                    graph.vertices[i].neighbors.Add(edge2);
                    graph.vertices[i].neighbors.Add(edge3);

                    graph.edges.Add(edge1);
                    graph.edges.Add(edge2);
                    graph.edges.Add(edge3);
                }
                if (i > 5 && i < 9)
                {
                    Edge edge1 = new Edge();
                    edge1.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i - 1].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i - 1].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    Edge edge2 = new Edge();
                    edge2.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i + 1].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i + 1].y - graph.vertices[i].y, 2.0))); //wzór dla i - i +5
                                                                                                                                                                             //edge.pheromoneValue = pheromoneValue;

                    Edge edge3 = new Edge();
                    edge3.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i].x - graph.vertices[i - 5].x, 2.0) + Math.Pow(graph.vertices[i - 5].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    Edge edge4 = new Edge();
                    edge4.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i].x - graph.vertices[i + 5].x, 2.0) + Math.Pow(graph.vertices[i + 5].y - graph.vertices[i].y, 2.0)));

                    edge1.vertex1 = graph.vertices[i];
                    edge1.vertex2 = graph.vertices[i - 5];
                    edge2.vertex1 = graph.vertices[i];
                    edge2.vertex2 = graph.vertices[i + 5];
                    edge3.vertex1 = graph.vertices[i];
                    edge3.vertex2 = graph.vertices[i + 1];
                    edge4.vertex1 = graph.vertices[i];
                    edge4.vertex2 = graph.vertices[i + 5];

                    //tworzenie DaWay
                    graph.vertices[i].neighbors.Add(edge1);
                    graph.vertices[i].neighbors.Add(edge2);
                    graph.vertices[i].neighbors.Add(edge3);
                    graph.vertices[i].neighbors.Add(edge4);

                    graph.edges.Add(edge1);
                    graph.edges.Add(edge2);
                    graph.edges.Add(edge3);
                    graph.edges.Add(edge4);
                }
                if (i == 9)
                {
                    Edge edge1 = new Edge();
                    edge1.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i - 5].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i - 5].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    Edge edge2 = new Edge();
                    edge2.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i + 5].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i + 5].y - graph.vertices[i].y, 2.0))); //wzór dla i - i +5
                                                                                                                                                                             //edge.pheromoneValue = pheromoneValue;

                    Edge edge3 = new Edge();
                    edge3.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i].x - graph.vertices[i - 1].x, 2.0) + Math.Pow(graph.vertices[i - 1].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    edge1.vertex1 = graph.vertices[i];
                    edge1.vertex2 = graph.vertices[i - 5];
                    edge2.vertex1 = graph.vertices[i];
                    edge2.vertex2 = graph.vertices[i + 5];
                    edge3.vertex1 = graph.vertices[i];
                    edge3.vertex2 = graph.vertices[i - 1];

                    //tworzenie DaWay
                    graph.vertices[i].neighbors.Add(edge1);
                    graph.vertices[i].neighbors.Add(edge2);
                    graph.vertices[i].neighbors.Add(edge3);

                    graph.edges.Add(edge1);
                    graph.edges.Add(edge2);
                    graph.edges.Add(edge3);
                }
                if (i == 10)
                {
                    Edge edge1 = new Edge();
                    edge1.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i + 1].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i + 1].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    Edge edge2 = new Edge();
                    edge2.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i - 5].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i - 5].y - graph.vertices[i].y, 2.0))); //wzór dla i - i +5
                                                                                                                                                                             //edge.pheromoneValue = pheromoneValue;

                    edge1.vertex1 = graph.vertices[i];
                    edge1.vertex2 = graph.vertices[i + 1];
                    edge2.vertex1 = graph.vertices[i];
                    edge2.vertex2 = graph.vertices[i - 5];

                    //tworzenie DaWay
                    graph.vertices[i].neighbors.Add(edge1);
                    graph.vertices[i].neighbors.Add(edge2);

                    graph.edges.Add(edge1);
                    graph.edges.Add(edge2);
                }
                if (i > 10 && i < 14)
                {
                    Edge edge1 = new Edge();
                    edge1.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i -1].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i - 1].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    Edge edge2 = new Edge();
                    edge2.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i + 1].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i + 1].y - graph.vertices[i].y, 2.0))); //wzór dla i - i +5
                                                                                                                                                                             //edge.pheromoneValue = pheromoneValue;

                    Edge edge3 = new Edge();
                    edge3.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i].x - graph.vertices[i + 5].x, 2.0) + Math.Pow(graph.vertices[i + 5].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    edge1.vertex1 = graph.vertices[i];
                    edge1.vertex2 = graph.vertices[i - 1];
                    edge2.vertex1 = graph.vertices[i];
                    edge2.vertex2 = graph.vertices[i + 1];
                    edge3.vertex1 = graph.vertices[i];
                    edge3.vertex2 = graph.vertices[i - 5];

                    //tworzenie DaWay
                    graph.vertices[i].neighbors.Add(edge1);
                    graph.vertices[i].neighbors.Add(edge2);
                    graph.vertices[i].neighbors.Add(edge3);

                    graph.edges.Add(edge1);
                    graph.edges.Add(edge2);
                    graph.edges.Add(edge3);
                }
                if (i == 14)
                {
                    Edge edge1 = new Edge();
                    edge1.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i - 1].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i - 1].y - graph.vertices[i].y, 2.0)));//wzór oblczania dla wierzhołków i - i+1);

                    Edge edge2 = new Edge();
                    edge2.distance = (int)(Math.Sqrt(Math.Pow(graph.vertices[i - 5].x - graph.vertices[i].x, 2.0) + Math.Pow(graph.vertices[i - 5].y - graph.vertices[i].y, 2.0))); //wzór dla i - i +5
                                                                                                                                                                             //edge.pheromoneValue = pheromoneValue;

                    edge1.vertex1 = graph.vertices[i];
                    edge1.vertex2 = graph.vertices[i - 1];
                    edge2.vertex1 = graph.vertices[i];
                    edge2.vertex2 = graph.vertices[i - 5];

                    //tworzenie DaWay
                    graph.vertices[i].neighbors.Add(edge1);
                    graph.vertices[i].neighbors.Add(edge2);

                    graph.edges.Add(edge1);
                    graph.edges.Add(edge2);
                }
            }

            return graph;
        }
    }
}

