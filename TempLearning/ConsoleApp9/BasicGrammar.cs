﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGrammar_namespace
{
    class tooool
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
        /// 对数组 冒泡排序 从大到小
        /// </summary>
        /// <param name="Arr"></param>
        public void BubbleSort(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++) {
                for (int j = Arr.Length - 1; j > 0; j--) {
                    if (Arr[j] > Arr[j - 1]) {
                        int temp = Arr[j];
                        Arr[j] = Arr[j - 1];
                        Arr[j - 1] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// 对数组 冒泡排序 从大到小
        /// </summary>
        /// <param name="Arr"></param>
        public void BubbleSort2(int[] Arr)
        {
            for(int i = 0; i < Arr.Length; i++) {
                for (int j = 0; j < Arr.Length - i - 1; j++) {
                    if (Arr[j] > Arr[j + 1]) {
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }
        }



        public int temp()
        {
            int num = 0;

            for (int i = 0; i <= 1000; i++) {
                if (i == 10) {
                    i++;
                    if (i == 11) {
                        num += i;
                        Console.WriteLine("num1 = " + num);
                        //return num; //return 会直接跳出这个public函数
                        break;  //break 是只跳出这个for循环，会执行num1 和 num3
                    }
                }
                if (i == 100) {
                    num += i;

                }
                if (i == 1000) {
                    num += i;
                    Console.WriteLine("num2 = " + num);
                    return num;
                }
            }
            Console.WriteLine("num3 = " + num);
            return num;
        }
    }
    class BasicGrammar
    { 

        static void Main(string[] args)
        {
            //1， % 的学习
            //int i = 19;
            //int j = i % 100;
            //Console.WriteLine(j); //19

            //2，foreach 和for 区别的学习
            //int[] n = { 1, 2, 3, 4, 5 };
            //foreach(int m in n) {
            //    Console.WriteLine("foreach:" + m);
            //    //output:"1,2,3,4,5"
            //}
            //for(int m = 0; m < n.Length; m++) {
            //    int temp = n[m];
            //    Console.WriteLine("for: " + temp);
            //    //output:"1,2,3,4,5"
            //}

            //3，Equals 和 ==的区别   不区分大小写
            //int[] n = new int[] { 1, 2, 3, 4, 5, 6 }; 
            //int[] m = new int[] { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine("是否等于: " + n.Equals(m));    //Fasle
            //Console.WriteLine("是否等于: " + (n == m));   //Fasle
            //string n = "asdfg";
            //string m = "asdfg";
            //string o = "Asdfg";
            //Console.WriteLine("是否等于: " + n.Equals(m)); //True
            //Console.WriteLine("是否等于: " + (n == m)); //True
            //Console.WriteLine("是否等于: " + (n == o)); //Fasle

            //4，strin.format
            //   与ToString
            //int i = 1;
            //Console.WriteLine(i.ToString("D5"));
            //Console.WriteLine(i.ToString("00000"));
            //Console.WriteLine(string.Format("{0:00000}", i));
            //Console.WriteLine(string.Format("{0:D5}", i));
            //都是输出 "00001"

            //5，不允许除以0
            //int i = 10;
            //int j = 0;
            //Console.WriteLine(i / j);

            //6，sring的length 和 非空string 
            //和三目运算  ? : ;
            //string s = "";
            //bool flag = true;
            //flag = (s.Length) > 0 ? flag : !flag;
            //Console.WriteLine(flag);
            //flag = (s == null) ? flag : !flag;
            //Console.WriteLine(flag);

            //7，可空类型
            //int? aa = null;
            //aa = 33;
            //Console.WriteLine(aa.HasValue);  //True
            //Console.WriteLine(aa.Value);  //33
            //if (aa.HasValue) {
            //    int bb = aa.Value;
            //    Console.WriteLine(bb);    //33
            //}

            //8，Dictionary的打印
            //Dictionary<int, int> ff = new Dictionary<int, int>();
            //ff.Add(1, 3);
            //ff.Add(2, 4);
            //ff.Add(5, 6);
            //ff.Add(3, 33);
            //ff.Add(4, 4);
            //foreach(KeyValuePair<int,int> num in ff) {
            //        Console.Write(num.Key + ", ");
            //        Console.WriteLine(num.Value);
            //}
            //foreach (KeyValuePair<int, int> num in ff) {
            //    Console.Write(num.Key + ", ");
            //    Console.WriteLine(num.Value);
            //    Console.WriteLine("{0}, {1}", num.Key, num.Value);
            //}

            //9，Linq的查询操作
            ////获取数据源，
            //var nums2 = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            //int [] nums = { 0, 1, 2, 3, 4, 5, 6 };
            ////创建查询
            //var numQuery2 =
            //    //from 子句指定数据源
            //    from num2 in nums2
            //    //where 子句指定应用筛选器
            //    where (num2 % 2) == 0
            //    //orderby num2 descending;
            //    //select 子句指定返回的元素的类型
            //    select num2;
            //    //select num).ToList();

            //var numQuery2Count = numQuery2.Count();
            //    //int numQuery = 
            //    //form num in nums
            //    //where (num/2) == 0
            //    //select num;
            //foreach(var num in numQuery2) {
            //    Console.WriteLine("{0}", num);
            //}
            //Console.WriteLine();
            //Console.WriteLine(numQuery2Count);

            //引用
            //int b = 100;
            //int c = 10;
            //int a = 1;
            //c = b;
            //a = c;
            //a = 100000;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //10000
            //100
            //100


            //string 和 char
            //string 的长度是从0开始的
            //string s = "123456";
            //int j = s.Length;
            //for(int i = 0; i < s.Length; i++) {
            //    Console.WriteLine("string[ " + i + " ] = " + s[i]);
            //}
            //string s = "121416";
            //string ss = "11";
            //List<char> OutputList = new List<char>();
            //for(int i = 0; i < s.Length; i++) {
            //    char temp = s[i];
            //    char compare = ss[0];
            //    if (temp==compare) {
            //        OutputList.Add(compare);
            //    }
            //}
            //foreach(int temp in OutputList) {
            //    Console.Write(temp);    ///49 49 49 
            //    Console.WriteLine();
            //}
            //foreach (char temp in OutputList) {
            //    Console.Write(temp);    ///1 1 1
            //    Console.WriteLine();
            //}

            //tooool ff = new tooool();
            //ff.temp();

            char x = '\0';
            Console.WriteLine("X=" + x + "de");
            x = ' ';

            tooool ff = new tooool();
            int[] Arr1 = { 3, 1, 2, 4, 6 };
            int[] Arr2 = { 3, 1, 2, 4, 6 };
            ff.BubbleSort(Arr1);
            foreach(int o in Arr1) {
                Console.Write(o);
            }

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            ff.BubbleSort2(Arr2);
            foreach (int o in Arr2) {
                Console.Write(o);
            }

            Console.ReadKey();
        }
    }
}
