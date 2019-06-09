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
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double OutputMedian = 0;
            if (nums1.Length == 0) {
                if (nums2.Length % 2 == 0) {
                    OutputMedian = (nums2[nums2.Length / 2] + nums2[(nums2.Length / 2) - 1]) * 1.0 / 2;
                    return OutputMedian;
                }
                else {
                    OutputMedian = nums2[nums2.Length / 2] * 1.0;
                    return OutputMedian;
                }
            }
            if (nums2.Length == 0) {
                if (nums1.Length % 2 == 0) {
                    OutputMedian = (nums1[nums1.Length / 2] + nums1[(nums1.Length / 2) - 1]) * 1.0 / 2; 
                    return OutputMedian;
                }
                else {
                    OutputMedian = nums1[nums1.Length / 2] * 1.0;
                    return OutputMedian;
                }
            }

            int[] MergerArray = new int[nums1.Length + nums2.Length];
            int Nums1Index = 0;
            int Nums2Index = 0;
            int TempIndex = 0;

            while (Nums1Index < nums1.Length && Nums2Index < nums2.Length) {
                if (nums1[Nums1Index] <= nums2[Nums2Index]) {
                    MergerArray[TempIndex] = nums1[Nums1Index];
                    TempIndex++;
                    Nums1Index++;
                }
                else {
                    MergerArray[TempIndex] = nums2[Nums2Index];
                    TempIndex++;
                    Nums2Index++;
                }
            }

            while (Nums1Index < nums1.Length) {
                MergerArray[TempIndex] = nums1[Nums1Index];
                TempIndex++;
                Nums1Index++;
            }

            while (Nums2Index < nums2.Length) {
                MergerArray[TempIndex] = nums2[Nums2Index];
                TempIndex++;
                Nums2Index++;
            }
            if (MergerArray.Length % 2 != 0) {
                OutputMedian = MergerArray[MergerArray.Length / 2] * 1.0;
                return OutputMedian;
            }
            else {
                OutputMedian = (MergerArray[MergerArray.Length / 2] + MergerArray[MergerArray.Length / 2 - 1]) / 2 * 1.0;
                return OutputMedian;
            }

            //while (true) {
            //    if (nums1.Length > Nums1Index && nums2.Length > Nums2Index) {
            //        if (nums1[Nums1Index] > nums2[Nums2Index]) {
            //            MergerArray[TempIndex] = nums2[Nums2Index];
            //            TempIndex++;
            //            Nums2Index++;
            //        }
            //        else {
            //            MergerArray[TempIndex] = nums1[Nums1Index];
            //            TempIndex++;
            //            Nums1Index++;
            //        }
            //    }
            //    else {
            //        if (MergerArray[nums1.Length+nums2.Length-1]==nums1.Max()|| MergerArray[nums1.Length + nums2.Length-1]==nums2.Max()) {
            //            break;
            //        }
            //    }
            //}
            //if (MergerArray.Length % 2 != 0) {
            //    OutputMedian = MergerArray[MergerArray.Length / 2] * 1.0;
            //    return OutputMedian;
            //}
            //else {
            //    OutputMedian = (MergerArray[MergerArray.Length / 2] + MergerArray[MergerArray.Length / 2 - 1]) / 2 * 1.0;
            //    return OutputMedian;
            //}
        }
    }
    class FindMedianSortedArrays
    {
        static void Main(string[] args)
        {
            int[] inputOne = { 10, 12, 14 };
            int[] inputTwo = { 11, 13 };

            Solution ff = new Solution();
            double OutPut = ff.FindMedianSortedArrays(inputOne, inputTwo);
            Console.Write("第一次测试  3 " + OutPut);
            Console.WriteLine();

            int[] inputOne2 = {};
            int[] inputTwo2 = { 1, 3, 4, 5 };
            OutPut = ff.FindMedianSortedArrays(inputOne2, inputTwo2);
            Console.Write("第二次测试  3.5 " + OutPut);
            Console.WriteLine();

            int[] inputOne3 = { 1, 4, 4, 5 };
            int[] inputTwo3 = {};
            OutPut = ff.FindMedianSortedArrays(inputOne3, inputTwo3);
            Console.Write("第三次测试  4 " + OutPut);
            Console.WriteLine();

            int[] inputOne4 = { 1, 12, 13, 15 };
            int[] inputTwo4 = { 1 };
            OutPut = ff.FindMedianSortedArrays(inputOne4, inputTwo4);
            Console.Write("第四次测试  12 " + OutPut);
            Console.WriteLine();

            Console.ReadKey();
        }

    }
}
