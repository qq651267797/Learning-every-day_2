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
        public List<char> Convert(string input, int LeveL)
        {
            List<char> OutListChar = new List<char>();

            if (input.Length == 0 || input == null) {
                Console.WriteLine("input == 空, 输入不合法");
                return OutListChar;
            }
            if (LeveL == 0) {
                Console.WriteLine("LeveL == 0, 输入不合法");
                return OutListChar;
            }
            if (LeveL == 1) {
                foreach (char i in input) {
                    OutListChar.Add(i);
                }
                return OutListChar;
            }

            //第一列 的间隔需要多少
            int Interval = 2 * (LeveL - 1);
            //是否可以支撑那么多行 
            int RowNumber = input.Length / Interval + 1;
            //当i超出边界时，则退出 0 ~ LeveL-1
            for (int i = 0; i < LeveL; i++) {
                //在处于边界时，对边界的最外层进行处理
                for (int j = 0; j < RowNumber; j++) {

                    if (i == 0 || i == LeveL - 1) {
                        if (Interval * j + i < input.Length) {
                            OutListChar.Add(input[Interval * j + i]);
                        }
                    }
                    else {
                        if (Interval * j + i < input.Length) {
                            OutListChar.Add(input[Interval * j + i]);
                        }
                        if (Interval * j + i + (LeveL - 1 - i) * 2 < input.Length) {
                            OutListChar.Add(input[Interval * j + i + (LeveL - 1 - i) * 2]);
                        }
                    }
                }
            }
            return OutListChar;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            List<char> OutListInt = new List<char>();
            string InputString = "ABCDEFGH";
            int Level = 0;
            OutListInt = ff.Convert(InputString, Level);

            foreach(char i in OutListInt) {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
