using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2有序数组的平方977
{
//给定一个按非递减顺序排序的整数数组 A，返回每个数字的平方组成的新数组，要求也按非递减顺序排序。
//示例 1：
//输入：[-4,-1,0,3,10]
//输出：[0,1,9,16,100]
//示例 2：
//输入：[-7,-3,2,3,11]
//输出：[4,9,9,49,121]

    class Solution
    {
        public List<int> SortedSquares(int[] Input)
        {
            List<int> OutList = new List<int>();
            int Left = 0;
            int Right = Input.Length - 1;
            while (Right >= Left) {
                int RightPow = (int)Math.Pow(Input[Right], 2);
                int LeftPow = (int)Math.Pow(Input[Left], 2);
                if (RightPow > LeftPow) {
                    OutList.Add(RightPow);
                    Right--;
                }
                else {
                    OutList.Add(LeftPow);
                    Left++;
                }
            }
            return OutList;
        }
        //private void InsertSort(List<double> inPutList)
        //{
        //    for(int i = 0; i < inPutList.Count; i++) {
        //        int j = i;
        //        double temp = inPutList[i];

        //        while (j > 0 && temp < inPutList[j - 1]) {
        //            inPutList[j] = inPutList[j - 1];
        //            j--;
        //        }
        //        inPutList[j] = temp;
        //    }
        //}
    }
    class SortedSquares
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            int[] A = { -4, -1, 0, 3, 10,15,16,18 };
            List<int> OutList = new List<int>();
            OutList = ff.SortedSquares(A);

            foreach(int i in OutList) {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
