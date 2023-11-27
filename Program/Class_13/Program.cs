using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_13 {
    class Program {
        static void Merge(int[] arr, int left, int right) {
            int[] temp = new int[arr.Length];
            int Left = 0, Right = 0, k = 0;
            int Mid = (left + right) / 2;
            k = Left = left;
            Right = Mid + 1;
            while (Left <= Mid && Right <= right) {
                temp[k++] = arr[Left] < arr[Right] ? arr[Left++] : arr[Right++];
            }

            if (Left > Mid) {
                for (int i = Right; i <= right; i++) {
                    temp[k++] = arr[i];
                }
            } else {
                for (int i = Left; i <= Mid; i++) {
                    temp[k++] = arr[i];
                }
            }

            for (int i = left; i <= right; i++) {
                arr[i] = temp[i];
            }
        }
        static void MergeSort(int[] arr, int left, int right) {
            //if (left == right)
            //    return;
            if (left < right) {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int start, int middle, int end) {
            //임시 배열 생성
            int[] leftarr = new int[middle - start + 1];
            int[] rightarr = new int[end - middle];

            int index = start;
            int left = 0;
            int right = 0;

            for (left = 0; index <= middle; left++) {
                leftarr[left] = arr[index++];
            }
            for (right = 0; index <= end; right++) {
                rightarr[right] = arr[index++];
            }
            index = start;
            left = 0;
            right = 0;

            while (left < leftarr.Length && right < rightarr.Length) {
                arr[index++] = leftarr[left] < rightarr[right] ? leftarr[left++] : rightarr[right++];
            }
            while (left < leftarr.Length)
                arr[index++] = leftarr[left++];
            while (right < rightarr.Length)
                arr[index++] = rightarr[right++];
        }

        static void Main(string[] args) {
            #region 병합정렬
            /* 하나의 리스트를 두 개의 균등한 크기로 분할하고 분할된 부분 리스트를 정렬한 다음, 
             * 두 개의 정렬된 부분의 리스트를 합하여 전체가 정렬된 리스트가 되게 하는 방법
             * 분할 : 입력 배열을 같은 크기의 2개의 부분 배열로 분할한다.
             * 정복 : 부분 배열을 정렬하며, 부분 배열의 크기가 충분히 작지 않으면,
             *        순환 호출을 이용하여 다시 분할 정복을 실행
             * 결합 : 정렬된 부분 배열들을 하나의 배열에 병합한다.
             */
            int[] arr = new int[] { 21, 10, 12, 20, 25, 13, 15, 22 };

            MergeSort(arr, 0, arr.Length - 1);

            foreach (var item in arr) {
                Console.Write(item + " ");
            }
            #endregion
        }
    }
}
