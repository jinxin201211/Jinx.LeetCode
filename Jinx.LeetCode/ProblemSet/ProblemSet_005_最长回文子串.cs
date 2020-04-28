using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_005_最长回文子串 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.TimeUnqualified; } }

        public void Test()
        {
            Console.WriteLine(LongestPalindrome("babad"));
        }

        /// <summary>
        /// "执行用时 :↵372 ms↵, 在所有 C# 提交中击败了↵23.24%↵的用户"
        /// "内存消耗 :↵22.9 MB↵, 在所有 C# 提交中击败了↵100.00%↵的用户"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindrome(string s)
        {
            for (int len = s.Length; len >= 0; len--)
            {
                //bool palindrome = true;
                for (int i = 0; i < s.Length - len + 1; i++)
                {
                    bool palindrome2 = true;
                    int begin = i, end = i + len - 1;
                    while (begin < end)
                    {
                        if (s[begin] != s[end])
                        {
                            palindrome2 = false;
                            break;
                        }
                        begin++;
                        end--;
                    }
                    if (palindrome2)
                    {
                        return s.Substring(i, len);
                    }
                }
                //if (palindrome)
                //{
                //    return len;
                //}
            }
            return "";
        }
    }
}
