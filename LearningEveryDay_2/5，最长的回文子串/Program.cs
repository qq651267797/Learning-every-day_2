using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_最长的回文子串
{
    //给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。
    //示例 1：
    //输入: "babad"
    //输出: "bab"
    //注意: "aba" 也是一个有效答案。
    //示例 2：
    //输入: "cbbd"
    //输出: "bb"

    public class Solution
    {
        public string LongestPalindrome(string input)
        {
            //char temp = input[0];
            //string s = temp + "ss";
            //return s;
            string outString = "";
            if(input == null || input.Length == 0) {
                throw new Exception();
            }
            int Start = 0;
            int End = 0;
            for(; End < input.Length; End++) {
                string temp = input.Substring(Start, End);
                string tempReverse = string.Join("", temp.Reverse());
                if (temp.Equals(tempReverse)) {
                    outString = temp;
                }
                else {
                    Start++;
                }
            }
            return outString;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            string input = "babad";
            //string temp = input.Substring(0, 1);
            string outPut = ff.LongestPalindrome(input);

            //char[] tempArr = temp.ToCharArray();
            //Array.Reverse(tempArr);
            //string outPut = new string(tempArr);

            //string outPut = string.Join("", temp.Reverse());

            //不能如下这个么写。。。是因为Reverse的问题
            //string outPut = Convert.ToString(temp.Reverse());

            Console.WriteLine(outPut);
            //Console.WriteLine(temp);
            Console.WriteLine();


            input = "cbbd";
            outPut = ff.LongestPalindrome(input);
            Console.WriteLine(outPut);

            Console.ReadKey();
        }
    }
}
