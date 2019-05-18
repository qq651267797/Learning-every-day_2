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
        public int[] SortedSquares(int[] A)
        {
            double sum = 0;

            for (int i = 0; i < A.Length; i++) {
                int temp = A[i];
                sum += Math.Pow(temp, 2);
            }
        }
    }
    class SortedSquares
    {
        static void Main(string[] args)
        {
        }
    }
}
