using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class AdjacencyList {
        //그래프의 노드
        //그래프의 인접 리스트
        List<int>[] vertex = null;
        int index = 0;
        bool[] visited = null;
        Queue<int> queue;

        public AdjacencyList(int size) {
            index = size;
            vertex = new List<int>[size];
            for (int i = 0; i < size; i++) {
                vertex[i] = new List<int>();
            }
        }

        public void AddEdge(int vertexIndex, int edge) {
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

        public void BFS(int root) {
            visited = new bool[index];
            queue = new Queue<int>();
            
            queue.Enqueue(root);
            visited[root] = true;

            int tmp = 0;
            while(queue.Count > 0) {
                tmp = queue.Dequeue();
                Console.Write(tmp + " ");
                
                if (vertex[tmp].Count > 0) {
                    for (int i = 0; i < vertex[tmp].Count; i++) {
                        if (!visited[vertex[tmp][i]]) {
                            visited[vertex[tmp][i]] = true;
                            queue.Enqueue(vertex[tmp][i]);
                        }
                    }
                }
            }
            Console.WriteLine(" ");
        }
    }
}
