using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_020_有效的括号 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.Unqualified; } }

        public void Test()
        {
            Console.WriteLine(IsValid2("()"));
            Console.WriteLine(IsValid2("()[]{}"));
            Console.WriteLine(IsValid2("([)]"));
            Console.WriteLine(IsValid2("{[]}"));
        }

        /// <summary>
        /// "执行用时 :↵104 ms↵, 在所有 C# 提交中击败了↵27.72%↵的用户"
        /// "内存消耗 :↵22 MB↵, 在所有 C# 提交中击败了↵11.11%↵的用户"
        /// </summary>
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Peek() == '[' && s[i] == ']' || stack.Peek() == '(' && s[i] == ')' || stack.Peek() == '{' && s[i] == '}')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(s[i]);
                    }
                }
            }
            return stack.Count == 0;
        }

        /// <summary>
        /// "执行用时 :↵92 ms↵, 在所有 C# 提交中击败了↵46.13%↵的用户"
        /// "内存消耗 :↵22.3 MB↵, 在所有 C# 提交中击败了↵11.11%↵的用户"
        /// </summary>
        public bool IsValid2(string s)
        {
            char[] stack = new char[s.Length];
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (index == 0)
                {
                    stack[index] = s[i];
                    index++;
                }
                else
                {
                    if (stack[index - 1] == '[' && s[i] == ']' || stack[index - 1] == '(' && s[i] == ')' || stack[index - 1] == '{' && s[i] == '}')
                    {
                        index--;
                    }
                    else
                    {
                        stack[index] = s[i];
                        index++;
                    }
                }
            }
            return index == 0;
        }
    }
}
