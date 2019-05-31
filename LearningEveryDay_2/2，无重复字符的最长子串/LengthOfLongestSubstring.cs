using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_无重复字符的最长子串
{
//给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。
//示例 1:
//输入: "abcabcbb"
//输出: 3 
//解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
//示例 2:
//输入: "bbbbb"
//输出: 1
//解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
//示例 3:
//输入: "pwwkew"
//输出: 3
//解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
//请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。

    public class Solution
    {
        public int LengthOfLongestSubstring2(string input)
        {
            //input.Trim(); 空格也算字符
            if (input == null || input.Length == 0) {
                return 0;
            }
            if (input.Length == 1) {
                return 1;
            }
            //key 不可以那啥重复
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int OutLength = 0;
            int First = 0;
            int ENDs = 0;
            for (; ENDs < input.Length; ENDs++) {
                char temp = input[ENDs];
                if (dic.ContainsKey(temp)) {
                    First = Math.Max(dic[temp] + 1, First);
                    dic[temp] = ENDs;
                }
                else {
                    dic.Add(temp, ENDs);
                }
                OutLength = Math.Max(OutLength, ENDs - First + 1);
            }
            return OutLength;
        }

        //public int LengthOfLongestSubstring3(string s)
        //{
        //    int OutLength = 0;
        //    int[] array = new int[128];
        //    for (int i = 0, j = 0; i < s.Length; i++) {

        //        j = Math.Max(array[s[i]], j);

        //        OutLength = Math.Max(OutLength, i - j + 1);

        //        array[s[i]] = i + 1;
        //    }
        //    return OutLength;
        //}

    }
    class LengthOfLongestSubstring
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();

            //string input = " abcdefghj"; //10
            //int OutLength = ff.LengthOfLongestSubstring2(input);
            //Console.Write(OutLength);
            //Console.WriteLine("               ");

            string input = "bbabcbbc";
            int OutLength = ff.LengthOfLongestSubstring2(input);
            Console.Write(OutLength);
            Console.WriteLine("               ");

            input = "pwwkew";
            OutLength = ff.LengthOfLongestSubstring2(input);
            Console.Write(OutLength);
            Console.WriteLine("               ");

            input = "abcabcabc";
            OutLength = ff.LengthOfLongestSubstring2(input);
            Console.Write(OutLength);
            Console.WriteLine("               ");



            Console.ReadKey();
        }
    }
}
