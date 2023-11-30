﻿using System;
using System.Collections;

namespace Class16 {
    class Program {
        static IEnumerable Load() {
            int data = 0;
            while (true) {
                data++;
                yield return data;

                if (data >= 10)
                    yield break;
            }
        }

        static void Main(string[] args) {
            #region yield return
            /*프로그램의 흐름을 다시 돌려주고 다시 되돌려받는 방식으로 제어하는 제어문.
             */
            foreach (var item in Load()) {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
