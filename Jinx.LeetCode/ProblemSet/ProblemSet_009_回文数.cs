using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_009_回文数 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.MemoryUnqualified; } }

        public void Test()
        {
            Console.WriteLine(IsPalindrome(0));
            Console.WriteLine(IsPalindrome(-1));
            Console.WriteLine(IsPalindrome(1));
            Console.WriteLine(IsPalindrome(10));
            Console.WriteLine(IsPalindrome(121));
        }

        /// <summary>
        /// "执行用时 :↵68 ms↵, 在所有 C# 提交中击败了↵95.51%↵的用户"
        /// "内存消耗 :↵16.4 MB↵, 在所有 C# 提交中击败了↵40.00%↵的用户"
        /// </summary>
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else if (x < 10)
            {
                return true;
            }
            else
            {
                string num = x.ToString();
                bool palidrome = true;
                for (int i = 0, j = num.Length - 1; i < j; i++, j--)
                {
                    if (num[i] != num[j])
                    {
                        palidrome = false;
                        break;
                    }
                }
                return palidrome;
            }
        }
    }
}
