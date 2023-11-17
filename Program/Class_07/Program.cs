using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Program;
namespace Class_07 {
    class Program {
        static void Main(string[] args) {
            #region 일반화 프로그래밍
            /*
             * 하나의 데이터가 특정 데이터 타입에 종속되지 않고 여러 테이터 타입을 가질 수 있는
             * 기술에 중점을 두어 재사용성을 높일 수 있는 프로그래밍 방법
             */

            //Deque<string> Deque = new Deque<string>();
            //Deque<int> int_Deque = new Deque<int>();
            //Deque.Set("string Deque");
            //int_Deque.Set(1000);

            /*
             * c++ 템플릿은 컴파일이 한 번 일어나며, C# 일반화는 컴파일이 2번 일어난다.
             * c++ 템플릿은 사용하지 않으면 컴파일을 하지 않는다.
             * C# 일반화는 사용하지 않더라도 그에 관련되니 정보를 저장하기 위한
             * 메타파일을 생성해야하므로 컴파일을 진행한다.
             */
            #endregion

            #region 범위 기반 반복문
            //int[] buffer = new int[5];

            //foreach (int element in buffer) {
            //    Console.WriteLine(element);
            //}
            #endregion
        }
    }
}
