using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_09 {
    public class Rifle : IEnumerator {
        private int[] bullet;
        private int index;

        public Rifle() {
            index = -1;
            bullet = new int[5];
        }

        //읽기 전용 프로퍼티 현재 위치의 데이터를 object타입으로 반환
        public object Current => bullet[index];
        //MoveNext 다음 위치로 이동 후, 데이터가 존재하면 true, 없다면 false를 반환
        public bool MoveNext() {
            return ++index < bullet.Length;
        }
        // Reset 인덱스를 초기 상태로 이동시킨다. 컬렉션의 인덱스를 -1로 설정한다.
        public void Reset() {
            index = -1;
        }
    }
    class Program {
        static void Main(string[] args) {
            #region 예외 처리
            //try {
            //    int[] array = new int[3];
            //    array[3] = 555;
            //    Console.WriteLine("프로그램 시작");
            //} catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //} finally {
            //    Console.WriteLine("프로그램 종료");
            //}

            #endregion

            #region 열거자
            //Rifle rifle = new Rifle();
            //while (rifle.MoveNext())
            //    Console.WriteLine(rifle.Current);

            #endregion
        }
    }
}
