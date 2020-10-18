using System;
using System.Collections.Generic;

public  class d
{
    public  List<List<int>> path_matrix = new List<List<int>>();
    public List<int> shortest_dist = new List<int>();
    private static readonly int NO_PARENT = -1;
    

    

    public static List<int> remove_loop(List<int> guzergah)

    {
        int dalga=0;
        for(int i=1;i<guzergah.Count;i++)
        {
            if(guzergah[0]==guzergah[i])
            {
                dalga = i;
                break;

            }
        }
        guzergah.RemoveRange(dalga, guzergah.Count-dalga);
        

        return guzergah;
    }
    public void dijkstra(int[,] adjacencyMatrix, int startVertex, int endVertex)
    {
        int nVertices = adjacencyMatrix.GetLength(0);
        path_matrix.Clear();
        shortest_dist.Clear();
        int[] shortestDistances = new int[nVertices];
        bool[] added = new bool[nVertices];

        for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)
        {
            shortestDistances[vertexIndex] = int.MaxValue;
            added[vertexIndex] = false;
        }

        shortestDistances[startVertex] = 0;

        int[] parents = new int[nVertices];

        parents[startVertex] = NO_PARENT;

        for (int i = 1; i < nVertices; i++)
        {
 
            int nearestVertex = -1;
            int shortestDistance = int.MaxValue;
            for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)
            {

                if (!added[vertexIndex] && shortestDistances[vertexIndex] < shortestDistance)
                {

                    nearestVertex = vertexIndex;
                    shortestDistance = shortestDistances[vertexIndex];



                }
            }


            added[nearestVertex] = true;


            for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)
            {
                int edgeDistance = adjacencyMatrix[nearestVertex, vertexIndex];

                if (edgeDistance > 0 && ((shortestDistance + edgeDistance) < shortestDistances[vertexIndex]))
                {
                    
                    parents[vertexIndex] = nearestVertex;
                    shortestDistances[vertexIndex] = shortestDistance + edgeDistance;
                    if (vertexIndex == endVertex)
                    {
                        //Console.WriteLine(shortestDistances[vertexIndex]);
                        shortest_dist.Add(shortestDistances[vertexIndex]);
                        path_matrix.Add( printSolution(startVertex, shortestDistances, parents, endVertex));
                    
                    }

                }

            }


           
        }


    }
    

    private static List<int> printSolution(int startVertex, int[] distances, int[] parents, int endVertex)
    {
        int nVertices = distances.Length;
        List<int> path = new List<int>();

        for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)
        {
            if (vertexIndex != startVertex)
            {
                path = printPath(endVertex, parents, path);
            }
        }
         path= remove_loop(path);
        /*for (int i = 0; i < path.Count; i++)
        {
            //Console.WriteLine(" " + path[i]);
        }*/
        return path;
    }

    private static List<int> printPath(int currentVertex,int[] parents, List<int> path)
    {
       
         
        if (currentVertex == NO_PARENT)
        {
            return path;
        }
       path.Add(currentVertex);
       printPath(parents[currentVertex], parents, path);
       //Console.Write(currentVertex + " ->");
        return path;
    }
    public void show()
    {
        
           Console.Write(shortest_dist[0] + "->");
            
            Console.Write(path_matrix[0][0] + " ");
           
            Console.WriteLine();
        }
    }
