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
        public int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int point1 = 0, point2 = 0;
            while (point2 < s.Length) {

                if (dic.ContainsKey(s[point2])) {
                    if (dic[s[point2]] + 1 > point1) {
                        point1 = dic[s[point2]] + 1;
                    }
                    else {
                        point1 = point1;
                    }
                    //point1 = dic[s[point2]] + 1 > point1 ? dic[s[point2]] + 1 : point1;
                    dic[s[point2]] = point2;
                }

                else {
                    dic.Add(s[point2], point2);
                }
                if (length > point2 - point1 + 1) {
                    length = length;
                }
                else {
                    length = point2 - point1 + 1;
                }
                point2++;
            }
            return length;
        }

        public int LengthOfLongestSubstring2(string input)
        {
            //input.Trim();
            if (input == null || input.Length == 0) {
                return 0;
            }
            if (input.Length == 1) {
                return 1;
            }
            int OutLength = 0;
            int tempLength = 0;
            return 0;
        }

        public int LengthOfLongestSubstring3(string s)
        {
            int OutLength = 0;
            int[] array = new int[128];
            for (int i = 0, j = 0; i < s.Length; i++) {

                j = Math.Max(array[s[i]], j);

                OutLength = Math.Max(OutLength, i - j + 1);

                array[s[i]] = i + 1;
            }
            return OutLength;
        }


    }
    class LengthOfLongestSubstring
    {
        static void Main(string[] args)
        {
            Solution ff = new Solution();

            string input = "abcabcbb";
            int OutLength = ff.LengthOfLongestSubstring3(input);
            Console.Write(OutLength);
            Console.WriteLine("               ");

            input = "bbbb";
            OutLength = ff.LengthOfLongestSubstring3(input);
            Console.Write(OutLength);
            Console.WriteLine("               ");

            input = "pwwkew";
            OutLength = ff.LengthOfLongestSubstring3(input);
            Console.Write(OutLength);
            Console.WriteLine("               ");

            Console.ReadKey();
        }
    }
}
