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

    // ArrayList 和 int 和 Array的区别在哪里呢
    // 
    // 还有List 和 LinkList的区别
    // List和LinkList的区别是,,List是有限制里面的内容的 限制参数

    // Convert.ToInt32 16 到底是一个什么样的存在
    // Convert 是不是和(int)一样的用法
    
    class Tool2
    {
        /// <summary>
        /// 对数组 插入排序
        /// </summary>
        /// <param name="ArraryList1"></param>
        private void InsertSort(int[] Arr)
        {
            for(int a = 1; a < Arr.Length; a++) {
                int b = Arr[a];
                int c = a;
                while((c > 0) && (Arr[c - 1]) > b) {
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
        public Dictionary<int,int> LookArrayIntersections(int[] A, int[] B)
        {
            this.InsertSort(A);
            this.InsertSort(B);
            //Dictionary<int, int> ADictionary = new Dictionary<int, int>();
            Dictionary<int, int> BDictionary = new Dictionary<int, int>();
            for (int i = 0; i < B.Length; i++) {
                BDictionary.Add(key: i, value: A[i]);
            }
            Dictionary<int, int> IntersectDictionary = new Dictionary<int, int>();

            if (A == null || A.Length == 0 || B == null || B.Length == 0) {
                return IntersectDictionary;
            }
            for(int i = 0; i < A.Length; i++) {
                int temp = A[i];
                bool BIncludedFlag = BDictionary.ContainsValue(temp);
                bool IntersectIncludedFlag = IntersectDictionary.ContainsValue(temp);
                if (BIncludedFlag && !IntersectIncludedFlag) {
                    int cur = 0;
                    IntersectDictionary.Add(cur, temp);
                    cur++;
                }
            }
            return IntersectDictionary;
        }
        //为了了解问题写出来的尝试代码

        //private void LookArrayIntersections3(int[] a, int[] b)
        //{
        //    InsertSort(a);
        //    InsertSort(b);

        //    List<int> SetList = new List<int>();
        //    if (a == null || a.Length == 0 || b == null || b.Length == 0) {
        //        return;
        //    }
        //    for (int i = 0; i < a.Length; i++) {
        //        int temp = a[i];
        //        for (int j = 0; j < b.Length; j++) {
        //            if (b[j] == temp && !(SetList.Contains(temp))) {
        //                SetList.Add(temp);
        //            }
        //        }
        //    }
        //    return;
        //}

        //为了了解问题写出来的尝试代码
        //public void InsertSort2(ArrayList Arr)
        //{
        //    for(int a = 1; a < (Convert.ToInt32(Arr.Count)); a++) {
        //        int b = Convert.ToInt32(Arr[a]);
        //        int c = a;
        //        while((c > 0) && (Convert.ToInt32(Arr[c-1]) > b)) {
        //            Arr[c] = Arr[c - 1];
        //            c--;
        //        }
        //        Arr[c] = b;
        //    }
        //}

        //为了了解问题写出来的尝试代码
        //public List<int> LookArrayIntersections2(ArrayList a, ArrayList b)
        //{
        //    InsertSort2(a);
        //    InsertSort2(b);

        //    List<int> SetList = new List<int>();
        //    if (a == null || a.Count == 0 || b == null || b.Count == 0) {
        //        return SetList;
        //    }
        //    for (int i = 0; i < a.Count; i++) {
        //        int temp = Convert.ToInt32(a[i]);
        //        for (int j = 0; j < b.Count; j++) {
        //            if (Convert.ToInt32(b[j]) == temp && !(SetList.Contains(temp))) {
        //                SetList.Add(temp);
        //            }
        //        }
        //    }
        //    return SetList;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tool2 ff = new Tool2();
            int[] Arr_1 = { 6, 1, 2, 6, 9, 8, 7, 2 };
            int[] Arr_2 = { 12, 6, 0, 5, 4, 3, 10, 11 };
            //ArrayList Arrary_1 = new ArrayList() { 6, 1, 2, 6, 9, 8, 7, 2 };
            //ArrayList Arrary_2 = new ArrayList() { 12, 6, 0, 5, 4, 3, 10, 11 };
            List<int> SetList = ff.LookArrayIntersections(Arr_1, Arr_2);
            //List<int> SetList2 =  ff.LookArrayIntersections2(Arrary_1, Arrary_2);
            //Console.Write(SetList.ToString());
            for(int x = 0; x < SetList.Count; x++) {
                Console.Write("SetList1----------------------");
                Console.WriteLine(SetList[x]);

            }
            //for (int x = 0; x < SetList2.Count; x++) {
            //    Console.Write("SetList2---------------------");
            //    Console.WriteLine(SetList2[0]);
            //}

            //List<int> SetList3 = ff.LookArrayIntersections(Arr_1, Arr_2);
            //for (int x = 0; x < SetList3.Count; x++) {
            //    Console.Write("SetList3---------------------");
            //    Console.WriteLine(SetList2[0]);
            //}



            Console.ReadKey();
        }
    }
}
