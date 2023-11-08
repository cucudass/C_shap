using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class Program {
        static void Main(string[] args) {
            //출력: Console.WriteLine();
            #region 자료형
            //byte stream = 1;
            //bool boolean = false;
            //char character = 'A';
            //short data = 200;
            //int integer = 100;
            //float[] buffer = new float[3];
            //buffer[0] = 1.15f;
            //buffer[1] = 2.15f;
            //double pi = 3.14;
            //decimal decimalData = 999m;
            //
            //Console.WriteLine("Stream: " + stream);
            //Console.WriteLine("boolean: " + boolean);
            #endregion

            #region 박싱(BOXING)
            /*
             값 형식의 데이털르 참조 형식으로 변환하는 과정
             */
            //int data = 5;
            //object obj = data; // 박싱
            //Console.WriteLine(obj);
            #endregion

            #region 언박싱(UnBoxing)
            /*
             참조 타입의 데이터를 데이터로 변환하는 과정
             */
            int count = 10;
            object obj1 = count;
            int result = (int)obj1;
            #endregion
        }
    }
}
