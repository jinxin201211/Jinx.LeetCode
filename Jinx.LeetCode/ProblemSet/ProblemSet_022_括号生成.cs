using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    class ProblemSet_022_括号生成 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.TimeUnqualified; } }

        public void Test()
        {
            GenerateParenthesis(1).Print<string>();
            GenerateParenthesis(2).Print<string>();
            GenerateParenthesis(3).Print<string>();
            GenerateParenthesis(4).Print<string>();
            GenerateParenthesis(5).Print<string>();
        }

        /// <summary>
        /// "执行用时 :↵492 ms↵, 在所有 C# 提交中击败了↵5.40%↵的用户"
        /// "内存消耗 :↵32.7 MB↵, 在所有 C# 提交中击败了↵100.00%↵的用户"
        /// </summary>
        public IList<string> GenerateParenthesis(int n)
        {
            if (n == 1)
            {
                return new List<string>() { "()" };
            }
            else
            {
                IList<string> subs = GenerateParenthesis(n - 1);
                IList<string> list = new List<string>();
                for (int i = 0; i < subs.Count; i++)
                {
                    for (int j = 0; j < subs[i].Length; j++)
                    {
                        string str = subs[i].Substring(0, j) + "()" + subs[i].Substring(j, subs[i].Length - j);
                        if (!list.Contains(str))
                        {
                            list.Add(str);
                        }
                    }
                }
                return list;
            }
        }
    }
}
