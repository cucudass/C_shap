using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class AdjacencyList<T> {
        //그래프의 노드
        //그래프의 인접 리스트
        List<T>[] vertex = null;
        int index = 0;
        public AdjacencyList(int size) {
            index = size;
            vertex = new List<T>[size];
            for (int i = 0; i < size; i++) {
                vertex[i] = new List<T>();
            }
        }

        public void AddEdge(int vertexIndex, T edge) {
            vertex[vertexIndex].Add(edge);
        }

        public void Display() {
            for (int i = 0; i < index; i++) {
                Console.Write(i + ": ");
                for (int j = 0; j < vertex[i].Count; j++) {
                    Console.Write(vertex[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
