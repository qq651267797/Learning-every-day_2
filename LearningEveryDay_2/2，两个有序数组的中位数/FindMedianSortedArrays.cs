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
        public void FindMedianSortedArrays(List<int> nums1, List<int> nums2)
        {
            foreach(int i in nums2) {
                nums1.Add(i);
            }
            int nums1Length = nums1.Count;
            nums1Length--;


        }
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
            ff.FindMedianSortedArrays(inputOne, inputTwo);
            Console.ReadKey();

        }
    }
}
