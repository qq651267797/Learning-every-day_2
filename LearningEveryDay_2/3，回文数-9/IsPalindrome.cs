using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_回文数_9
{
    public class Solution
    {
        public bool IsPalindrome(int InputInt)
        {
            //输出的是否为回文数，默认为true, 默认为回文数
            bool OutputBool = true;
            int InputIntLength = InputInt.ToString().Length;

            //输入的长度为1，那么一定为回文数
            if (InputIntLength == 1) {
                return OutputBool;
            }
            //输入的长度为0，那么输入一定不合法
            if (InputIntLength == 0) {
                Console.WriteLine("输入的不合法 " + InputInt + " 长度为0 ");
                OutputBool = false;
                return OutputBool;
            }
            //如果为负数，一定不为回文数
            if (InputInt < 0) {
                Console.WriteLine("输入的 " + InputInt + "为负数，负数不为回文数");
                OutputBool = false;
                return OutputBool;
            }

            //对输入的inputint 进行 反转
            int InputIntReverse = 0;
            int TempInputInt = InputInt;
            while (TempInputInt != 0) {
                //取出最后一位数
                int temp = TempInputInt % 10;
                //最后一位数乘以10，加上最后的第二位数
                InputIntReverse = InputIntReverse * 10 + temp;
                //删除最后一位数
                TempInputInt /= 10;
            }
            OutputBool = (InputInt == InputIntReverse ? true : false);
            return OutputBool;
        }
    }
    class IsPalindrome
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();

            int InputInt = 121;
            bool OutputBool = ff.IsPalindrome(InputInt);
            Console.WriteLine();
            Console.WriteLine(OutputBool);
            Console.WriteLine("____________________");
            Console.WriteLine();

            InputInt = -121;
            OutputBool = ff.IsPalindrome(InputInt);
            Console.WriteLine();
            Console.WriteLine(OutputBool);
            Console.WriteLine("____________________");
            Console.WriteLine();

            InputInt = 10;
            OutputBool = ff.IsPalindrome(InputInt);
            Console.WriteLine();
            Console.WriteLine(OutputBool);
            Console.WriteLine("____________________");
            Console.WriteLine();

            InputInt = 12121;
            OutputBool = ff.IsPalindrome(InputInt);
            Console.WriteLine();
            Console.WriteLine(OutputBool);
            Console.WriteLine("____________________");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
