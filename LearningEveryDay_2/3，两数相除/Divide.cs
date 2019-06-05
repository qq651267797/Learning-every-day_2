using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_两数相除
{
//给定两个整数，被除数 dividend 和除数 divisor。将两数相除，要求不使用乘法、除法和 mod 运算符。

//返回被除数 dividend 除以除数 divisor 得到的商。

//示例 1:

//输入: dividend = 10, divisor = 3
//输出: 3
//示例 2:

//输入: dividend = 7, divisor = -3
//输出: -2
    public class Solution
    {
        public int Divide(int Dividend, int Divisor)
        {
            if (Divisor == 0) {
                return 0; 
      //          throw new Exception();
            }
            if (Divisor == 1) {
                return Dividend;
            }
            if (Divisor == -1) {
                if (int.MinValue >= Dividend) {
                    return int.MaxValue;
                }
                return ~Dividend + 1;
            }
            //false = "-"     true = "+"
            // 异或运算取符号
            //int sign = ((dividend < 0) ^ (divisor < 0)) ? -1 : 1;
            bool FinalSign = true;
            if (Dividend > 0 && Divisor > 0) {
                FinalSign = true;
            }
            else if (Dividend < 0 && Divisor < 0) {
                FinalSign = true;
            }
            else {
                FinalSign = false;
            }
            //商 = 0
            int Quotient = 0;

            int DividendAbs = this.MathAbs(Dividend);
            int DivisorAbs = this.MathAbs(Divisor);
            //如果除数小于被除数
            if (DividendAbs < DivisorAbs) {
                return Quotient;
            }

            Quotient = 1;   //商数
            int Remainder = 0;  //余数
            while(DividendAbs > (DivisorAbs * Quotient)) {
                //如果除数大于被除数
                //除数 减去 被除数乘以商  的值，，仍大于被除数
                //认为未除尽，商可以更大
                if (DividendAbs - DivisorAbs * Quotient >= DivisorAbs) {
                    Quotient++;
                }
                else {
                    Remainder = DividendAbs - DivisorAbs * Quotient;
                    break;
                }
            }
            return FinalSign ? Quotient : (~Quotient + 1);
        }
        /// <summary>
        /// 取绝对值
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int MathAbs(int input)
        {
            int temp = input >> 31;
            temp = (temp == 0 ? input : (~input + 1));
            return temp;
        }
    }
    class Divide
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            int i = 10;
            int j = 3;
            int Quotient = ff.Divide(i, j);
            Console.WriteLine();
            Console.WriteLine(Quotient);
            Console.WriteLine();

            i = -10;
            j = 3;
            Quotient = ff.Divide(i, j);
            Console.WriteLine();
            Console.WriteLine(Quotient);
            Console.WriteLine();

            i = 10;
            j = -3;
            Quotient = ff.Divide(i, j);
            Console.WriteLine();
            Console.WriteLine(Quotient);
            Console.WriteLine();

            i = 0;
            j = 10;
            Quotient = ff.Divide(i, j);
            Console.WriteLine();
            Console.WriteLine(Quotient);
            Console.WriteLine();

            i = 50;
            j = 2;
            Quotient = ff.Divide(i, j);
            Console.WriteLine();
            Console.WriteLine(Quotient);
            Console.WriteLine();

            i = int.MaxValue;
            j = -1;
            Quotient = ff.Divide(i, j);
            Console.WriteLine();
            Console.WriteLine(Quotient);
            Console.WriteLine();

            i = int.MinValue;
            j = -1;
            Quotient = ff.Divide(i, j);
            Console.WriteLine();
            Console.WriteLine(Quotient);
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
