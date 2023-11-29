using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class AdjacencyMatrix<T> {
        //정점의 수
        private int index = 0;
        T[] vertex = null;
        int[,] edges = null;

        public AdjacencyMatrix(int size) {
            vertex = new T[size];
            edges = new int[size, size];
        }
        
        public void InsertVertex(T data) {
            if (index < vertex.Length)
                vertex[index++] = data;
            else
                return;
        }

        public void InsertEdge(int x, int y) {
            if(x < edges.Length && y < edges.Length) {
                edges[x, y] = 1;
                edges[y, x] = 1;
            } else {
                return;
            }  
        }

        public void Display() {
            Console.WriteLine("Vertex Size: " + index);
            Console.WriteLine("");
            for (int i = 0; i < index; i++) {
                for(int j = 0; j < index; j++) {
                    Console.Write(edges[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
