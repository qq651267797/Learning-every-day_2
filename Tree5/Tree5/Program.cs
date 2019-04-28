using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random ran = new Random();
            List<int> List = new List<int>();
            while (List.Count < 30) {
                int ListData = ran.Next(1, 100);

                if (! List.Contains(ListData)) {
                    List.Add(ListData);
                }
            }

            //for (int i = 0; i < List.Count; i++) {
            //    Console.WriteLine("第{0}个数为：{1}", i, List[i]);
            //}

            int size = 1;
            for(int i = 0; i < List.Count; i++) {
                Console.Write("|" + size + "|");
                size++;
                Console.WriteLine(List[i]);
            }

            //for(int i = 0; i < List.Count; i++) {
            //    //int num = List[i];
                
            //    for(int j = i; j < List.Count; j++) {
            //        if (List[j] == List[i]) {
            //            Console.Write("存在_"+j);
            //            //Console.WriteLine(List[i]);
            //            //Console.WriteLine(List[j]);
            //        }
            //        else {
            //            Console.Write("不存_"+j);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadKey();
            //作者：w884540
            //来源：CSDN
            //原文：https://blog.csdn.net/w884540/article/details/52356032 
            //            版权声明：本文为博主原创文章，转载请附上博文链接！
        }
    }
}
