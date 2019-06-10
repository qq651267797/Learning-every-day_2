using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_字符串转换整数_8
{
    public class Solution
    {
        public int MyAtoi(string InputStr)
        {
            int OutputStr = 0;

            int InputStringLength = InputStr.Length;
            if (InputStr == null || InputStringLength == 0) {
                return OutputStr;
            }
            //为正则是 true   为负就是 false
            bool Flag = true;
            int Left = 0;
            int Right = 0;

            //去除前面的空格
            for (int i = 0; i < InputStringLength; i++) {
                if (InputStr[i] == ' ') {
                    Left++;
                    Right++;
                }
                else {
                    break;
                }
            }
            //Left 和 Right 在同一起点线上

            if (InputStr[Left] == '-') {
                Flag = false;
                Left++;
                Right++;
            }
            else if (InputStr[Left] == '+') {
                Left++;
                Right++;
            }



            for(int i = 0; i < InputStringLength; i++) {
                //如果是正号 或者 是 负号
                if(InputStr[i] == 45 || InputStr[i] == 43) {
                    Right++;
                    int tempInt = 1;
                    if (InputStr[i-1] >= 48 && InputStr[i-1] <= 57)

                }
                //如果是 空格
                else if (InputStr[i] == 32) {
                    Left++;
                    Right++;
                }
                //如果是数字
                else if (InputStr[i] >= 48 && InputStr[i] <= 57) {
                    Right++;
                }
                //如果是 字母 或者 其他符号
                else {
                    OutputStr = InputStr.Substring(Left, Right);
                    if (OutputStr.Length == 0) {
                        return string0_0;
                    }
                    else {
                        return OutputStr;
                    }
                }
            }
        }
    }
    class MyAtoi
    {
        static void Main(string[] args)
        {
        }
    }
}
