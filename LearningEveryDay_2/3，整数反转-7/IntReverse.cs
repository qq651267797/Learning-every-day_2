using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_整数反转_7
{
    public class Solution
    {
        public int IntReverse(int InputInt)
        {
            int OutPutInt = 0;
            //此标志用来区分正负的，默认为正
            bool Flag = true;
            if (InputInt < 0) {
                Flag = false;
            }
            else if (InputInt == 0) {
                Console.WriteLine("输入的值为 " + InputInt + " 为0 ");
                return 0;
            }
            else {
                Flag = true;
            }
            //取绝对值
            InputInt = this.MathAbs(InputInt);
            //处理的次数
            int Times = 0;
            int InputIntLength = InputInt.ToString().Length;
            while (Times < InputIntLength) {
                for(int i = InputIntLength; i > 0; i--) {
                    int HighOrder = (int)Math.Pow(10, i);
                    int LowOrder = (int)Math.Pow(10, i - 1);

                    int TempInt = InputInt % HighOrder / LowOrder;
                    TempInt = TempInt * ((int)Math.Pow(10, Times));
                    Times++;

                    if (OutPutInt + TempInt < Int32.MinValue) {
                        return 0;
                    }
                    else if(OutPutInt + TempInt > Int32.MaxValue - 1) {
                        return 0;
                    }
                    else {
                        OutPutInt += TempInt;
                    }
                }
            }
            OutPutInt = Flag ? OutPutInt : (-1 * OutPutInt);
            return OutPutInt;
        }
        /// <summary>
        /// 取绝对值
        /// </summary>
        /// <param name="InputInt"></param>
        /// <returns></returns>
        private int MathAbs(int InputInt)
        {
            int temp = InputInt >> 31;
            temp = (temp == 0 ? InputInt : (~InputInt + 1));
            return temp;
        }

        /// 网上的
        /// 网上的
        public int Reverse(int x)
        {
            int ans = 0;
            while (x != 0) {
                int temp = x % 10;

                // 检查是否越界
                if (ans > 0x7FFFFFFF / 10 || ans == 0x7FFFFFFF / 10 && temp > 0x7FFFFFFF % 10) {
                    return 0;
                }
                if (ans < 0x80000000 / 10 || ans == 0x80000000 / 10 && temp < 0x80000000 % 10) {
                    return 0;
                }

                ans = ans * 10 + temp;
                x /= 10;
            }
            return ans;
        }
    }
    class IntReverse
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            int InputInt = 123;
            int OutputInt = ff.IntReverse(InputInt);
            Console.WriteLine();
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine("____________________");

            InputInt = -123;
            OutputInt = ff.IntReverse(InputInt);
            Console.WriteLine();
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine("____________________");

            InputInt = 120;
            OutputInt = ff.IntReverse(InputInt);
            Console.WriteLine();
            Console.WriteLine(OutputInt);
            Console.WriteLine();
            Console.WriteLine("____________________");

            Console.ReadKey();
        }
    }
}
