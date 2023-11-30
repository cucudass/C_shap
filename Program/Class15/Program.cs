using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Program;
namespace Class15 {
    class Program {
        static void Main(string[] args) {
            #region 너비 우선 탐색
            /*root 노드에서부터 인접한 노드를 먼저 탐색하는 방법.*/
            // Queue에 Root 노드를 넣어준다.
            // visited[] 방문 체크
            // 반복문이 돌아가는 위치
            // 1. Queue가 비어있을 때 까지 반복.
            // 2. Queue에서 데이터를 뽑는다.
            // 3. Queue에서 뽑은 데이터를 출력.
            // 4. 반복문을 이용해서 자기와 인접한 노드를 Queue에 넣습니다.
            // 5. 방문하지 않은 정점이라고 하면 해당 vertex 방문 체크를 하고 Queue에 데이터를 넣어준다.

            //AdjacencyList list = new AdjacencyList(7);

            //list.AddEdge(0, 1);
            //list.AddEdge(0, 2);
            //list.AddEdge(1, 3);
            //list.AddEdge(1, 4);
            //list.AddEdge(2, 5);
            //list.AddEdge(2, 6);

            //list.AddEdge(0, 1);
            //list.AddEdge(0, 2);
            //list.AddEdge(0, 4);
            //list.AddEdge(1, 2);
            //list.AddEdge(2, 3);
            //list.AddEdge(2, 4);

            //list.BFS(0);

            #endregion

            #region DFS(깊이 우선 탐색)
            /*root 노드에서 시작해서 다음 분기로 넘어가기 전에
             *해당 분기를 완벽하게 탐색하는 방법
             */
            //AdjacencyList list = new AdjacencyList(7);

            //list.AddEdge(0, 1);
            //list.AddEdge(0, 2);
            //list.AddEdge(1, 3);
            //list.AddEdge(1, 4);
            //list.AddEdge(2, 5);
            //list.AddEdge(2, 6);

            //list.DFS(0);
            #endregion
        }
    }
}
