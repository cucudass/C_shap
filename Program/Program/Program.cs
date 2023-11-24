using System;
using System.Collections;
using System.Collections.Generic;

namespace Program {
    class Program {
        static void Merge(int[] arr, int left, int right) {
            int[] temp = arr;
            int L = 0, R = 0;




            for (int i = left; i < right; i++) {
                arr[i] = temp[i];
            }
        }
        static void MergeSort(int[] arr, int left, int right) {
            int mid = 0;
            mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, right);
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
            int[] arr = new int[8] { 21, 10, 12, 20, 25, 13, 15, 22 };
            MergeSort(arr, 0, arr.Length-1);

            #endregion
        }
    }
}
