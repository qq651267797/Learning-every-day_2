using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_namespace
{
    class SimpleAlgorithm
    {
        /// <summary>
        /// 对数组 插入排序
        /// </summary>
        /// <param name="ArraryList1"></param>
        private void InsertSort(int[] Arr)
        {
            for (int a = 1; a < Arr.Length; a++) {
                int b = Arr[a];
                int c = a;
                while ((c > 0) && (Arr[c - 1]) > b) {
                    Arr[c] = Arr[c - 1];
                    c--;
                }
                Arr[c] = b;
            }
        }
        /// <summary>
        /// 二分查找法
        /// </summary>
        /// <param name="Arr"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        private int BinarySearch(int[] Arr,int Data)
        {
            int Min = 0;
            int Max = Arr.Length - 1;
            int Mid;
            while (Min <= Max) {
                Mid = Min + ((Max - Min) >> 1);
                if (Arr[Mid] > Data) {
                    Max = Mid - 1;
                }
                else if (Arr[Mid] < Data) {
                    Min = Mid + 1;
                }
                else {
                    return Mid;
                }
            }

            return -1;
        }

    }
    class Sort_Text
    {
        static void Main(string[] args)
        {
        }
    }
}
