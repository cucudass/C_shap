using System;
using System.Collections;
using System.Collections.Generic;

namespace Program {
    class Program {
        static void Main(string[] args) {
            #region 그래프
            /* 정점(vertex)과 간선(Edge)들이 서로 복잡하게 연결되어 있는 자료구조
             * 정점(vertex) - 노드(Node)라고도 하며, 데이터가 저장되는 그래프의 기본 원소
             * 간선(Edge) - 링크(Link)라고도 하며, 정점 감의 관계를 나타낸다.
             * 인접 정점(adjacent vertex) - 하나의 정점에서 간선에 의해 직접 연결되어 있는 정점
             * 차수(Degree) - 정점에 연결된 간선의 수를 의미
             * 진입차수 - 외부에서 오는 간선의 수를 의미
             * 진출차수 - 외부로 향하는 간선의 수를 의미
             * 단순 경로(Simple Path) - 경로 중에서 반복되는 간선이 없는 경로를 의미한다.
             * 사이클(Cycle) - 시작 정점과 종료 정점이 같은 단순 경로를 의미한다.
             */
            #endregion

            #region 인접행렬
            /*
            AdjacencyMatrix<string> matrix = new AdjacencyMatrix<string>(4);

            matrix.InsertVertex("A");
            matrix.InsertVertex("B");
            matrix.InsertVertex("C");
            matrix.InsertVertex("D");

            //A
            matrix.InsertEdge(0, 1);
            matrix.InsertEdge(0, 2);
            matrix.InsertEdge(0, 3);

            //B
            matrix.InsertEdge(1, 2);

            //C
            matrix.InsertEdge(2, 3);

            matrix.Display();
             */
            #endregion

            #region 인접리스트
            char[] ch = new char[] { 'A', 'B', 'C', 'D', 'E' };
            AdjacencyList<char> list = new AdjacencyList<char>(5);

            for (int i = 0; i < ch.Length; i++) {
                list.InsertVertex(ch[i]);
            }

            list.AddEdge(0, 'B');
            list.AddEdge(1, 'A');
            list.AddEdge(1, 'C');
            list.AddEdge(2, 'B');
            list.AddEdge(2, 'D');
            list.AddEdge(3, 'C');
            list.AddEdge(3, 'E');
            list.AddEdge(4, 'D');

            list.Display();

            #endregion
        }
    }
}
