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
            string outString = "";
            if(input == null || input.Length == 0) {
                return outString;
            }
            if (input.Length == 1) {
                return input;
            }
            int Start = 0;
            int End = 0;
            while (End < input.Length) {
                string temp = input.Substring(Start, End);
                string tempReverse = string.Join("", temp.Reverse());
                if (temp.Equals(tempReverse)) {
                    outString = temp;
                }
                else {
                    Start++;
                }
            }

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
        public string LongestPalindrome2(string input)
        {
            string outString = "";

            if (input == null || input.Length == 0) {
                return outString;
            }
            if (input.Length == 1) {
                return input;
            }
            int Start = 0;
            int Str_Length = 0;
            int mid = 1;

            for
        }
        public string LongestPalindrome3(string s)
        {
            if (s == "") return s;
            int maxlen = 1;
            int start = 0;

            for (int i = 0; i < s.Length; i++) {
                int j = i - 1, k = i + 1;
                while (j >= 0 && k < s.Length && s[j] == s[k]) {
                    if (k - j + 1 > maxlen) {
                        maxlen = k - j + 1;
                        start = j;
                    }
                    j--;
                    k++;
                }
            }

            //for (int i = 0; i < s.Length; i++) {
            //    int j = i, k = i + 1;
            //    while (j >= 0 && k < s.Length && s[j] == s[k]) {
            //        if (k - j + 1 > maxlen) {
            //            maxlen = k - j + 1;
            //            start = j;
            //        }
            //        j--;
            //        k++;
            //    }
            //}
            return s.Substring(start, maxlen);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();
            string input = "babad";
            //string temp = input.Substring(0, 1);
            string outPut = ff.LongestPalindrome3(input);

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
            outPut = ff.LongestPalindrome3(input);
            Console.WriteLine(outPut);

            Console.ReadKey();
        }
    }
}
