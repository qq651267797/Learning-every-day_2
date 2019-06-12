using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_字符串转换整数_8
{
    //请你来实现一个 atoi 函数，使其能将字符串转换成整数。
    //该函数会根据需要丢弃无用的开头空格字符，直到寻找到第一个非空格的字符为止。
    //第一个非空字符为正或者负号时，则将该符号与之后面尽可能多的连续数字组合起来，作为该整数的正负号；
    //假如第一个非空字符是数字，则直接将其与之后连续的数字字符组合起来，形成整数。
    //假设我们的环境只能存储 32 位大小的有符号整数，那么其数值范围为[−231, 231− 1]。
    //如果数值超过这个范围，qing返回 INT_MAX(231 − 1) 或 INT_MIN(−231) 。
    public class Solution
    {
        public int MyAtoi(string InputStr)
        {
            int OutputInt = 0;

            int InputStringLength = InputStr.Length;
            if (InputStr == null || InputStringLength == 0) {
                return OutputInt;
            }
            //为正则是 true   为负就是 false
            bool Flag = true;
            int Left = 0;
            //int Right = 0;
            //int IntmAX = int.MaxValue;
            //int IntMin = int.MinValue;

            //去除前面的空格
            for (int i = 0; i < InputStringLength; i++) {
                if (InputStr[i] == ' ') {
                    Left++;
                    //Right++;
                }
                else {
                    break;
                }
            }
            //如果是 正号
            if (InputStr[Left] == '+') {
                Left++;
                //Right++;
                if (Left < InputStringLength && !(InputStr[Left] >= '0' && InputStr[Left] <= '9')) {
                    return OutputInt;
                }
            }
            //如果是 负号
            else if (InputStr[Left] == '-') {
                Left++;
                //Right++;
                Flag = false;
                if (Left < InputStringLength && !(InputStr[Left] >= '0' && InputStr[Left] <= '9')) {
                    return OutputInt;
                }
            }
            //Left 和 Right 在同一起点线上

            for (int i = Left; i < InputStringLength; i++) {
                //如果是 数字
                if (InputStr[Left] >= '0' && InputStr[i] <= '9') {
                    int InputStr_Int = InputStr[Left] - '0';

                    //如果为 正数，但是大于int MAX
                    if (Flag && OutputInt >= (int.MaxValue / 10) && InputStr_Int > 7) {
                        OutputInt = int.MaxValue;
                        return OutputInt;
                    }
                    //如果为 负数，并且小于int Min
                    else if (!Flag && OutputInt <= Math.Abs((int.MinValue / 10)) && InputStr_Int > 8) {
                        OutputInt = int.MinValue;
                        return OutputInt;
                    }
                    //如果不为加完后 不大于且不小于，那就先加
                    else {
                        OutputInt = OutputInt * 10 + InputStr_Int;
                        Left++;
                        if (Left < InputStringLength && !(InputStr[Left] >= '0' && InputStr[Left] <= '9')) {
                            break;
                        }
                    }
                }
                //如果是 字母 或者 其他符号
                else {
                    if (OutputInt == 0) {
                        return 0;
                    }
                    else {
                        break;
                    }
                }
            }
            OutputInt = (Flag ? OutputInt : (~OutputInt + 1));
            return OutputInt;
        }
    }
    class MyAtoi
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            string InputStr = "42";
            int OutputInt = ff.MyAtoi(InputStr);
            Console.WriteLine();
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine();

            InputStr = "     -42 ds";
            Console.WriteLine();
            OutputInt = ff.MyAtoi(InputStr);
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine();

            InputStr = "-4193 with words";
            Console.WriteLine();
            OutputInt = ff.MyAtoi(InputStr);
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine();

            InputStr = "words and 987";
            Console.WriteLine();
            OutputInt = ff.MyAtoi(InputStr);
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine();

            InputStr = "-words and 987";
            Console.WriteLine();
            OutputInt = ff.MyAtoi(InputStr);
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine();

            InputStr = "-4444-44";
            Console.WriteLine();
            OutputInt = ff.MyAtoi(InputStr);
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine();

            InputStr = "-6666+66";
            Console.WriteLine();
            OutputInt = ff.MyAtoi(InputStr);
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine();

            InputStr = "-2147483649";
            Console.WriteLine();
            OutputInt = ff.MyAtoi(InputStr);
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine();

            InputStr = "2147483648";
            Console.WriteLine();
            OutputInt = ff.MyAtoi(InputStr);
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
