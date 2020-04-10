using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_017_电话号码的字母组合 : ISolution
    {
        public void Test()
        {
            IList<string> result = LetterCombinations2("23");
            result.Print();
        }

        struct TreeNode
        {
            public char Value;
            public TreeNode[] Children;
        }

        /// <summary>
        /// "执行用时 :↵272 ms↵, 在所有 C# 提交中击败了↵92.02%↵的用户"
        /// "内存消耗 :↵31.6 MB↵, 在所有 C# 提交中击败了↵20.00%↵的用户"
        /// </summary>
        /// <returns></returns>
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }
            Dictionary<char, string> dict = new Dictionary<char, string>() {
                { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" }
            };

            TreeNode[] childNodes = null;
            TreeNode[] parentNodes = null;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                string value = dict[digits[i]];
                parentNodes = new TreeNode[value.Length];
                for (int j = 0; j < value.Length; j++)
                {
                    parentNodes[j] = new TreeNode { Value = value[j], Children = childNodes };
                }
                childNodes = parentNodes;
            }

            TreeNode root = new TreeNode { Children = parentNodes };

            Stack<TreeNode> preLookup = new Stack<TreeNode>();
            char[] chr = new char[digits.Length];
            List<string> result = new List<string>();
            PreLookUp(root, chr, 0, ref result);

            return result;
        }

        private void PreLookUp(TreeNode node, char[] chr, int level, ref List<string> result)
        {
            if (node.Children == null)
            {
                result.Add(new string(chr));
            }
            else
            {
                for (int i = 0; i < node.Children.Length; i++)
                {
                    chr[level] = node.Children[i].Value;
                    PreLookUp(node.Children[i], chr, level + 1, ref result);
                }
            }
        }

        /// <summary>
        /// "执行用时 :↵272 ms↵, 在所有 C# 提交中击败了↵92.02%↵的用户"
        /// "内存消耗 :↵31.6 MB↵, 在所有 C# 提交中击败了↵20.00%↵的用户"
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public IList<string> LetterCombinations2(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }
            char[] chr = new char[digits.Length];
            List<string> result = new List<string>();
            PreLookUp(digits.ToCharArray(), chr, 0, ref result);

            return result;
        }

        string[] dict = new string[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        private void PreLookUp(char[] digits, char[] chr, int level, ref List<string> result)
        {
            if (level == digits.Length)
            {
                result.Add(new string(chr));
            }
            else
            {
                string chars = dict[digits[level] - '2'];
                for (int i = 0; i < chars.Length; i++)
                {
                    chr[level] = chars[i];
                    PreLookUp(digits, chr, level + 1, ref result);
                }
            }
        }
    }
}
