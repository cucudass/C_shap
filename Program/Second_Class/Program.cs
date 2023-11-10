using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02{
    public class Item {
        private int price;
        public string name;

        public void View() {
            Console.WriteLine("name : " + name);
            Console.WriteLine("price : " + price);
        }
    }

    public class Vector3 {
        public void Distance(ref int x) {
            x = 100;
        }
        public void Lerp(in int x) {
            Console.WriteLine("x의 값: " + x);
        }
        public void MoveToward(out int x) {
            x = 999;
        }
        public void Normalize(params object[] list) {
            int sum = 0;
            for (int i = 0; i < list.Length; i++) {
                sum += (int)list[i];
                Console.WriteLine(sum);
            }
        }

    }
    class Program {
        static void Main(string[] args) {
            #region 가비지 컬렉터
            /*
             동적으로 할당된 메모리 영역 가운데 더 이상 사용할 수 없게 된 영역을 탐지하여 자동으로 해제하는 기법
             */
            //{
            //    Item item = new Item();
            //    item.View();
            //}

            //Item potion = new Item();
            #endregion

            #region 매개변수 한정자
            Vector3 vector3 = new Vector3();
            int x;
            //ref: 하나의 변수에 서로 다른 이름으로 사용할 수 있는 키워드            
            /*
            vector3.Distance(ref x);
            Console.WriteLine("x의 값: " + x);
            */
            // in : 읽기 전용으로 적용되며, 참조로 전달하는 키워드
            //vector3.Lerp(x);

            // out : 출력용 매개 변수로 함수 내에서 값을 반드시 초기화해야 한다.
            /*
            vector3.MoveToward(out x);
            Console.WriteLine("x의 값: " + x);
            */

            //params: 가변 길이 매개변수
            /*
            vector3.Normalize(1,2,3,4,5);
            */
            #endregion
        }
    }
}
