using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12 {
    class Program {
        public static void Swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void QuickSort(int[] arr, int start, int end) {
            if (start >= end)
                return;

            int pivot = start;
            int left = start + 1;
            int right = end;

            //left가 right보다 크거나 같을 때까지 반복...
            while (left <= right) {
                /* left가 end보다 작거나 같으면 반복실행.
                 * pivot 값보다 left의 값이 작을 때 left를 오른쪽으로 이동
                 */
                while (left <= end && arr[left] <= arr[pivot])
                    left++;
                /* right가 start보다 크면 반복실행.
                 * pivot 값보다 right 값이 클 때 right를 왼쪽으로 이동
                 */
                while (right > start && arr[right] >= arr[pivot])
                    right--;

                if (left > right)
                    Swap(ref arr[pivot], ref arr[right]);
                else
                    Swap(ref arr[left], ref arr[right]);
            }
            QuickSort(arr, start, right - 1);
            QuickSort(arr, right + 1, end);
        }
        static void Main(string[] args) {
            #region 퀵정렬
            /* 기준점을 획득한 다음 해당 기준점을 기준으로 배여을 나누고 한 쪽에는 기준점보다 작은 항목들이 위치하고
             * 다른 쪽에는 기준점보다 끈 항목들이 위치한다.
             * 
             * 나뉘어진 하위 배열에 대해 재귀적으로 퀵 정렬을 호출하여 모든 배열이 기본 배열이 될 때까지 반복하면서 정렬하는 알고리즘
             * 시간복잡도: O(log n)
             */
            int[] arr = new int[9] { 5, 3, 8, 4, 9, 1, 6, 2, 7 };

            QuickSort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
            #endregion
        }
    }
}
