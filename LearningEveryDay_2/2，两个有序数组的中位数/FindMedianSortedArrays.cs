using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_两个有序数组的中位数
{
//给定两个大小为 m 和 n 的有序数组 nums1 和 nums2。
//请你找出这两个有序数组的中位数，并且要求算法的时间复杂度为 O(log(m + n))。
//你可以假设 nums1 和 nums2 不会同时为空。
//示例 1:
//nums1 = [1, 3]
//nums2 = [2]
//则中位数是 2.0

    class Solution
    {
        public double FindMedianSortedArrays2(int[] nums1, int[] nums2)
        {
            int First = 0;
            int Second = 0;
            int TotalNum = nums1.Length + nums2.Length;

            if (TotalNum % 2 == 0) {
                First = (nums1.Length + nums2.Length) / 2 - 1;
                Second = (nums1.Length + nums2.Length) / 2;
            }
            else {
                First = Second = (nums1.Length + nums2.Length) / 2;
            }

            int indexOne = 0, indexTwo = 0;
            double sum = 0;

            while (indexOne < nums1.Length && indexTwo < nums2.Length) {
                if (nums1[indexOne] < nums2[indexTwo]) {
                    if (indexOne + indexTwo == First || indexOne + indexTwo == Second) {
                        sum += nums1[indexOne];
                    }
                    indexOne++;
                }
                else {
                    if (indexOne + indexTwo == First || indexOne + indexTwo == Second) {
                        sum += nums2[indexTwo];
                    }
                    indexTwo++;
                }
            }
            while (indexOne < nums1.Length) {
                if (indexOne + indexTwo == First || indexOne + indexTwo == Second) {
                    sum += nums1[indexOne];
                }
                indexOne++;
            }
            while (indexTwo < nums2.Length) {
                if (indexOne + indexTwo == First || indexOne + indexTwo == Second) {
                    sum += nums2[indexTwo];
                }
                indexTwo++;
            }
            return First == Second ? sum : sum / 2;
        }

    }
    class FindMedianSortedArrays
    {
        static void Main(string[] args)
        {
            int[] inputOne = { 0, 1, 2, 3, 4 };
            int[] inputTwo = { 1, 3, 5, 4, 5 };

            Solution ff = new Solution();
            double OutPut = ff.FindMedianSortedArrays2(inputOne, inputTwo);
            Console.Write(OutPut);
            Console.WriteLine();

            Console.ReadKey();
        }

    }
}
