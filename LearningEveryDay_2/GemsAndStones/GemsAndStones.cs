using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsAndStones_namespace
{
//给定字符串J 代表石头中宝石的类型，和字符串 S代表你拥有的石头。 
//S 中每个字符代表了一种你拥有的石头的类型，你想知道你拥有的石头中有多少是宝石。

//J 中的字母不重复，J 和 S中的所有字符都是字母。字母区分大小写，因此"a"和"A"是不同类型的石头。

//示例 1:
//输入: J = "aA", S = "aAAbbbb"
//输出: 3
//示例 2:
//输入: J = "z", S = "ZZ"
//输出: 0

//注意:
//S 和 J 最多含有50个字母。
// J 中的字符不重复。
    class GemsAndStones
    {
        public int NumberIntersections(string A, string B)
        {
            int num = 0;
            Dictionary<int, char> myDictionary = new Dictionary<int, char>();

            for(int i = 0; i < A.Length; i++) {
                myDictionary.Add(i, A[i]);
            }
            //foreach(KeyValuePair<int,char> ff in myDictionary) {
            //    Console.WriteLine("number2 " + ff.Value);
            //}
            for(int j = 0; j < B.Length; j++) {
                if (myDictionary.ContainsValue(B[j])) {
                    num++;
                }
            }
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

            int num2 = ff.NumberIntersections(A, B);
            Console.WriteLine(num2);

            Console.ReadKey();
        }
    }
}
