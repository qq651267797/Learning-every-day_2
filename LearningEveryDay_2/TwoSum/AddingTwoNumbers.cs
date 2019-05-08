using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTwoNumbers_namespace
{

    //给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的
    //那 两个 整数，并返回他们的数组下标。

    //你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
    //示例:
    //给定 nums = [2, 7, 11, 15], target = 9

    //因为 nums[0] + nums[1] = 2 + 7 = 9
    //所以返回[0, 1]

    class AddingTwoNumbers
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

        public int[] TwoSum(int[] A, int Together)
        {
            Dictionary<int, int> ff = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++) {
                ff.Add(key: i, value: A[i]);
            }
            this.InsertSort(A);
            int[] FinallyList = new int[2];

            for (int i = 0; i < A.Length; i++) {
                if (A[i] > Together) {
                    return FinallyList;
                }
                for (int j = i + 1; j < A.Length; j++) {
                    if (A[j] > Together) {
                        break;
                    }
                    if ((A[i] + A[j]) > Together) {
                        break;
                    }
                    else if ((A[i] + A[j]) == Together) {
                        FinallyList[0] = A[i];
                        FinallyList[1] = A[j];
                        return FinallyList;
                    }
                }
            }
            throw new Exception();
        }
        //private int[] Find(int[] A)
        //{

        //}
    }
    class TwoSum1
    {
        static void Main(string[] args)
        {
            AddingTwoNumbers ff = new AddingTwoNumbers();
            int[] num = { 3, 5, 9, 12, 16, 5, 6 };
            int Together = 11;
            int[] FinallyList = ff.TwoSum(num, Together);
            Console.WriteLine("数组中的第{0}个数 和 第{1}个数相加 等于" + Together, FinallyList[0], FinallyList[1]);

            Console.ReadKey();
        }
    }
}
