using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Graph
{
    class MGraph
    {
        
        public int Vertices;
        public int[,] AdjacencyMatrix;

        public MGraph() { }

        public MGraph(int Vertices, int[,] adjMatrix)
        {
            this.Vertices = Vertices;
            this.AdjacencyMatrix = adjMatrix;
        }

        public void creat(int Vertices, int[,] adjMatrix)
        {
            this.Vertices = Vertices;
            this.AdjacencyMatrix = adjMatrix;
        }

        public string DFS(int startVertex=0)
        {
            List<int> s = new List<int>();
            int []visited = new int[this.Vertices];
            int i, j, k, start;
            string result = "";

            for (i=0;i<Vertices;i++)
            {
                if (visited[i] == 0)
                {
                    visited[i] = 1;
                    result = result + i.ToString() + " ";
                    s.Add(i);
                    start = startVertex;
                    while(s.Count != 0)
                    {
                        for(k = s.First(), j= start;j<this.Vertices;j++)
                        {
                            if(this.AdjacencyMatrix[i,j] != 0 && visited[j] == 0)
                            {
                                visited[j] = 1;
                                result = result + j.ToString() + " ";
                                s.Add(j);
                                break;
                            }
                        }
                        if (j == this.Vertices)
                        {
                            start = s.First();
                            s.RemoveAt(s.Count() - 1);
                        }
                        else continue;
                    }
                }
            }
            return result;
            //Console.ReadKey();
        }

        public string BFS(int startVertex = 0)
        {
            Queue<int> q1 = new Queue<int>();
            Queue<int> q2 = new Queue<int>();
            Queue<int> temp = new Queue<int>();
            int[] visited = new int[this.Vertices];

            string result = "";
            int i, j, k;

            for (i = 0; i < this.Vertices; i++)
            {
                if (visited[i] == 0)
                {
                    visited[i] = 1;
                    result = result + i.ToString() + " ";
                    q1.Enqueue(i);
                    do
                    {
                        while (q1.Count != 0)
                        {
                            for (j = 0, k = q1.Peek(), q1.Dequeue(); j < this.Vertices; j++)
                            {
                                if (this.AdjacencyMatrix[k, j] != 0 && visited[j] == 0)
                                {
                                    result = result + j.ToString() + " ";
                                    visited[j] = 1;
                                    q2.Enqueue(j);
                                }
                            }
                        }
                        temp = q1;
                        q1 = q2;
                        q2 = temp;
                    } while (q1.Count != 0);
                }
            }
            return result;
        }


        public void DisplayAdjacencyMatrix()
        {
            for (int i = 0; i < Vertices; i++)
            {
                for (int j = 0; j < Vertices; j++)
                {
                    Console.Write(AdjacencyMatrix[i, j]);
                }
                Console.WriteLine();
            }

        }

    }

    class ALGraph
    {
        public LinkedList<int>[] algraph;
        public int Vertices;

        public ALGraph() { }

        public ALGraph(int Vertices)
        {
            this.Vertices = Vertices;
            this.algraph = new LinkedList<int>[Vertices];
            for(int i=0;i<Vertices;i++)
            {
                this.algraph[i] = new LinkedList<int>();
            }
        }

        public void creat(int Vertices, int[,] adjMatrix)
        {
            int i,j;
            this.Vertices = Vertices;
            this.algraph = new LinkedList<int>[Vertices];
            for (i = 0; i < Vertices; i++)
            {
                this.algraph[i] = new LinkedList<int>();
            }

            for (i = 0; i < Vertices; i++)
            {
                algraph[i].AddLast(i);
            }

            for(i=0;i<Vertices;i++)
            {
                for(j=0;j<Vertices;j++)
                {
                    if(adjMatrix[i,j] == 1)
                    {
                        algraph[i].AddLast(j);
                    }
                }
            }
        }

        public string Print()
        {
            string result = "";
            string arrow = " --> ";
            string enter = "\r\n";
            string space = " ";
            for (int i=0;i<Vertices;i++)
            {
                LinkedListNode<int> current = algraph[i].First;
                result = result + i.ToString();
                System.Diagnostics.Debug.Write(i);
                result = result + arrow; 
                System.Diagnostics.Debug.Write(" --> ");
                current = current.Next;
                while (current != null)
                {
                    result = result + current.Value.ToString();
                    System.Diagnostics.Debug.Write(current.Value);
                    result = result + space;
                    System.Diagnostics.Debug.Write(" ");
                    current = current.Next;
                }
                result = result + enter;
                System.Diagnostics.Debug.Write('\n');
            }
            return result;
        }
    }
}
