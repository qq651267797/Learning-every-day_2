using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Z字型变换_6
{
    //将一个给定字符串根据给定的行数，以从上往下、从左到右进行 Z 字形排列。
    //比如输入字符串为 "LEETCODEISHIRING" 行数为 3 时，排列如下：
    //L   C   I   R
    //E T O E S I I G
    //E   D   H   N
    //之后，你的输出需要从左往右逐行读取，产生出一个新的字符串，比如："LCIRETOESIIGEDHN"。

    //请你实现这个将字符串进行指定行数变换的函数：
    //string convert(string s, int numRows);
    //    示例 1:

    //输入: s = "LEETCODEISHIRING", numRows = 3
    //输出: "LCIRETOESIIGEDHN"
    //示例 2:

    //输入: s = "LEETCODEISHIRING", numRows = 4
    //输出: "LDREOEIIECIHNTSG"
    //解释:

    //L     D     R
    //E   O E   I I
    //E C   I H   N
    //T     S G
    public class Solution
    {
        public List<int> Convert(string input, int Level)
        {
            List<char> OutListChar = new List<char>();

            int Interval = 2 * (Level - 1);
            //if (Interval > input.Length) {

            //}
            int RowNumber = input.Length / Interval + 1;
            //当i超出边界时，则退出 0 ~ Level-1
            for (int i = 0; i < Level; i++) {
                //在处于边界时，对边界的最外层进行处理
                for (int j = 0; j < RowNumber; j++) {
                    if (i == 0 || i == Level - 1) {
                        if (Interval * i + j < input.Length) {
                            OutListChar.Add(input[Interval * i + j]);
                        }
                        else {
                            continue;
                        }
                    }
                    else {
                        if (Interval * i + j < input.Length) {
                            OutListChar.Add(input[Interval * i + j]);
                        }

                    }
                }

            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            List<int> OutListInt = new List<int>();
            string InputString = "ABCDEFGHIJK";
            int Level = 3;
            OutListInt = ff.Convert(InputString, Level);

            foreach(int i in OutListInt) {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
