using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_003_无重复字符的最长子串 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.Unqualified; } }

        public void Test()
        {
            Console.WriteLine(LengthOfLongestSubstring(" "));
            Console.WriteLine(LengthOfLongestSubstring("qwerty"));
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
        }

        /// <summary>
        /// "执行用时 :↵516 ms↵, 在所有 C# 提交中击败了↵12.42%↵的用户"
        /// "内存消耗 :↵24.8 MB↵, 在所有 C# 提交中击败了↵46.67%↵的用户"
        /// </summary>
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            for (int i = 0; i < s.Length - max; i++)
            {
                int length = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    bool repeat = false;
                    for (int k = i; k < j; k++)
                    {
                        if (s[k] == s[j])
                        {
                            repeat = true;
                            break;
                        }
                    }
                    if (repeat)
                    {
                        break;
                    }
                    else
                    {
                        length++;
                    }
                }
                if (max < length)
                {
                    max = length;
                }
            }
            return max;
        }
    }
}
