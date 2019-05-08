using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseConversion_namespace
{

//实现函数 ToLowerCase()，该函数接收一个字符串参数 str，并将该字符串中的大写字母转换成小写字母，之后返回新的字符串。
//示例 1：
//输入: "Hello"
//输出: "hello"
//示例 2：
//输入: "here"
//输出: "here"
//示例 3：
//输入: "LOVELY"
//输出: "lovely"


    class CaseConversion
    {
        public string ToLower(string str)
        {
            if (str == null || str.Length == 0) {
                return null;
            }
            str = str.ToLower();
            return str;
        }

    }
    class Progarm
    {
        static void Main(string[] args)
        {
            CaseConversion ff = new CaseConversion();
            string str1 = "Hello";
            //str1 = ff.ToLower(str1);
            Console.WriteLine(ff.ToLower(str1));
            str1 = "here";
            Console.WriteLine(ff.ToLower(str1));
            str1 = "LOVELY";
            Console.WriteLine(ff.ToLower(str1));
            str1 = "";
            Console.WriteLine(ff.ToLower(str1));
            str1 = "LOVELY Here";
            Console.WriteLine(ff.ToLower(str1));
            Console.ReadKey();
        }
    }
}
