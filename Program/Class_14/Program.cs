using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Program;
namespace Class_14 {
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
            /* 그래프에서 어느 노드들이 간선으로 연결되어 있는지를 나타내는 행렬이며,
             * 2차원 배열로 구현되어 있고 노드 사이에 간선이 있다면 1, 없다면 0으로 표현한다.
             */
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
            /* 각 노드에 연결된 노드들을 원소로 갖는 리스트들의 배열을 의마하며,
             * 인접리스트가 있다면 [i]는 i 번째 노드에 연결된 노드들을 원소로 가지는 리스트
             */
            //AdjacencyList<int> list = new AdjacencyList<int>(7);

            //list.AddEdge(0, 1);
            //list.AddEdge(0, 2);
            //list.AddEdge(1, 3);
            //list.AddEdge(1, 4);
            //list.AddEdge(2, 5);
            //list.AddEdge(2, 6);

            //list.Display();
            #endregion
        }
    }
}
