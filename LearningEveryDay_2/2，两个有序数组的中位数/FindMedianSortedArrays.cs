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
        public double FindMedianSortedArrays(List<int> nums1, List<int> nums2)
        {
            double OutPut = 0;
            foreach(int i in nums2) {
                nums1.Add(i);
            }
            this.InsertSort(nums1);
            if (nums1.Count == 0 || nums1.Count == 1) {
                throw new Exception();
            }
            int nums1Count = nums1.Count;
            if (nums1Count % 2 == 1) {
                int temp = nums1Count / 2;
                OutPut = nums1[temp];
                //OutPut = curr;
                return OutPut;
            }
            else {
                int temp = nums1Count / 2;
                double curr_1 = nums1[temp] * 1.0;
                double curr_2 = nums1[temp - 1] * 1.0;

                OutPut = (curr_1 + curr_2) / 2;
                return OutPut;
            }
            throw new Exception();
        }
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="inPutList"></param>
        private void InsertSort(List<int> inPutList)
        {
            for (int i = 0; i < inPutList.Count; i++) {
                int j = i;
                int temp = inPutList[i];

                while (j > 0 && temp < inPutList[j - 1]) {
                    inPutList[j] = inPutList[j - 1];
                    j--;
                }
                inPutList[j] = temp;
            }
        }
        public double FindMedianSortedArrays2(List<int> nums1, List<int> nums2)
        {
            int First = 0;
            int Second = 0;
            int TotalNum = nums1.Count + nums2.Count;

            if (TotalNum % 2 == 0) {
                First = (nums1.Count + nums2.Count) / 2 - 1;
                Second = (nums1.Count + nums2.Count) / 2;
            }
            else {
                First = Second = (nums1.Count + nums2.Count) / 2;
            }

            int indexOne = 0, indexTwo = 0;
            double sum = 0;

            while (indexOne < nums1.Count && indexTwo < nums2.Count) {
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
            while (indexOne < nums1.Count) {
                if (indexOne + indexTwo == First || indexOne + indexTwo == Second) {
                    sum += nums1[indexOne];
                }
                indexOne++;
            }
            while (indexTwo < nums2.Count) {
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
            List<int> inputOne = new List<int>(); 
            List<int> inputTwo = new List<int>();
            inputOne.Add(1);
            inputOne.Add(3);

            inputTwo.Add(2);

            Solution ff = new Solution();
            double OutPut = ff.FindMedianSortedArrays(inputOne, inputTwo);
            Console.Write(OutPut);
            Console.WriteLine();

            inputOne.Clear();
            inputTwo.Clear();
            inputOne.Add(1);
            inputOne.Add(2);
            inputTwo.Add(3);
            inputTwo.Add(4);
            OutPut = ff.FindMedianSortedArrays(inputOne, inputTwo);
            Console.Write(OutPut);

            Console.ReadKey();
        }

    }
}
