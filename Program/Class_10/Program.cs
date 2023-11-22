using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_10 {
    class Program {
        static void Main(string[] args) {
            #region 등차수열
            //int a = 0;
            //int d = 0;
            //int cnt = 0;

            //Console.Write("첫째 항: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("공차: ");
            //d = Convert.ToInt32(Console.ReadLine());
            //Console.Write("반복 횟수: ");
            //cnt = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= cnt; i++) {
            //    Console.Write(a + (i - 1) * d + " ");
            //}
            #endregion

            #region 등비수열
            //Console.Write("첫 항: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("공비: ");
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.Write("횟수: ");
            //int cnt = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < cnt; i++) {
            //    Console.WriteLine(n * (Math.Pow(d, i)));
            //}
            #endregion

            #region 무명 형식
            /*
             * 이름이 존재하지 않는 객체 또는 변수를 의미
             * 무명 형식의 경우 값을 읽기만 할 수 있다.
             */
            //var data = new { Name = "Data", Value = 10 };
            //Console.WriteLine("data.Name: " + data.Name + ", data.Value: " + data.Value);
            #endregion
        }
    }
}
