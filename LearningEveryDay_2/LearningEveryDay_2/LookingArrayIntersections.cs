using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookingArrayIntersections
{
//给定两个数组，编写一个函数来计算它们的交集。

//示例 1:

//输入: nums1 = [1,2,2,1], nums2 = [2,2]
//输出: [2]
//示例 2:

//输入: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
//输出: [9,4]
//说明:

//输出结果中的每个元素一定是唯一的。
//我们可以不考虑输出结果的顺序。
    class Tool2
    {
        /// <summary>
        /// 对数组 插入排序
        /// </summary>
        /// <param name="ArraryList1"></param>
        public void InsertSort(ArrayList Arr)
        {
            for(int a = 1; a < Arr.Count; a++) {
                int b = Convert.ToInt32(Arr[a]);
                int c = a;
                while((c > 0) && (Convert.ToInt32(Arr[c]) - 1) > b) {
                    Arr[c] = Arr[c - 1];
                    c--;
                }
                Arr[c] = b;
            }
        }
        /// <summary>
        /// 寻找数组中的交集，
        /// 存放在SetList中b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void LookArrayIntersections(ArrayList a, ArrayList b)
        {
            InsertSort(a);
            InsertSort(b);

            LinkedList<int> SetList = new LinkedList<int>();
            if (a == null || a.Count == 0 || b == null || b.Length == 0) {
                return;
            }
            for (int i = 0; i < a.Length; i++) {
                int temp = a[i];
                for (int j = 0; j < b.Length; j++) {
                    if (b[j] == temp && !(SetList.Contains(temp))) {
                        SetList.AddLast(temp);
                        break;
                    }
                }
            }
            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tool2 ff = new Tool2();
            int[] Arr_1 = { 6, 1, 2, 6, 9, 8, 7, 2 };
            int[] Arr_2 = { 12, 6, 0, 5, 4, 3, 10, 11 };
            ArrayList Arrary_1 = new ArrayList() { 6, 1, 2, 6, 9, 8, 7, 2 };
            ArrayList Arrary_2 = new ArrayList() { 12, 6, 0, 5, 4, 3, 10, 11 };
            ff.LookArrayIntersections(Arr_1, Arr_2);
            ff.LookArrayIntersections(Arrary_1, Arrary_2);
        }
    }
}
