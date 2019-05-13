using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGrammar_namespace
{
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





            Console.ReadKey();
        }
    }
}
