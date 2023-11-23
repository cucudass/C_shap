using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11 {
    class Program {
        public static void Search(int[] arr, int start, int end, int find) {
            if (start <= end) {
                int mid = (start + end) / 2;
                if (arr[mid] == find) {
                    Console.WriteLine($"값({arr[mid]})이 존재.");
                } else {
                    if (arr[mid] > find)
                        Search(arr, start, mid - 1, find);
                    else
                        Search(arr, mid + 1, end, find);
                }
            } else {
                Console.WriteLine("값이 없음...");
            }
        }
        static void Main(string[] args) {
            #region 이진 탐색
            /*
             * 오름차순으로 정렬된 리스트에서 특정한 값의 위치를 찾는 알고리즘
             */
            int[] arr = new int[5] { 3, 2, 5, 4, 1 };
            int n = 0;
            Array.Sort(arr); //숫자를 오름차순으로 정렬한다.

            Console.Write("찾으려는 값: ");
            n = Convert.ToInt32(Console.ReadLine());
            Search(arr, 0, arr.Length - 1, n);

            #endregion
        }
    }
}
