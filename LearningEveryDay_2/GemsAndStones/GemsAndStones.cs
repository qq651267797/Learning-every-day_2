using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsAndStones_namespace
{
    class GemsAndStones
    {
        public int NumberIntersections(string A,string B)
        {
            int num = 0;
            if (A == null || B == null || A.Length == 0 || B.Length == null) {
                return num;
            }
            for(int i = 0; i < A.Length; i++) {
                for(int j = 0; j < B.Length; j++) {
                    if (A[i].Equals(B[j])) {
                        num++;
                    }
                }
            }
            return num;
        }
        //public int NumberIntersections2(string A, string B)
        //{
        //    int num = 0;
        //    for (int i = 0; i < A.Length; i++) {
        //        //for (int j = 0; j < B.Length; j++) {
        //            if (B.Contains(A[i].ToString())) {
        //                num++;
        //            }
        //            //写反了
        //            //if (A[i].ToString().Contains(B)) {
        //            //    num++;
        //            //}
        //        //}
        //    }
        //    return num;
        //}
        public int NumberIntersections2(string A, string B)
        {
            int num = 0;
            List<char> AList = new List<char>();
            for(int i = 0; i < A.Length; i++) {
                AList.Add(A[i]);
            }
            //foreach(char i in A){
            //    AList.Add(i);
            //}
            for(int j = 0; j < B.Length; j++) {
                if (AList.Contains(B[j])) {
                    num++;
                }
            }
            //foreach(char j in B) {
            //    if (AList.Contains(j)) {
            //        num++;
            //    }
            //}
            return num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GemsAndStones ff = new GemsAndStones();
            string A = "aA";
            string B = "aAAbbb";

            int num = ff.NumberIntersections(A, B);
            Console.WriteLine(num);

            int num2 = ff.NumberIntersections2(A, B);
            Console.WriteLine(num2);

            Console.ReadKey();
        }
    }
}
