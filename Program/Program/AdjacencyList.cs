using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class AdjacencyList<T> {
        //그래프의 노드
        //그래프의 인접 리스트
        List<T> vertex = null;
        List<T>[] edge = null;
        int index = 0;
        public AdjacencyList(int size) {
            vertex = new List<T>(size);
            edge = new List<T>[size];

        }

        public void InsertVertex(T data) {
            vertex.Add(data);
        }

        public void AddEdge(int x, T y) {
            edge[x].Add(y);
        }

        public void Display() {
            for (int i = 0; i < index; i++) {
                Console.Write(vertex[i] + " ");
                for (int j = 0; j < index; j++) {
                    Console.Write(edge[j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
