using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_151_翻转字符串里的单词 : ISolution
    {
        public void Test()
        {
            Console.WriteLine($"----------------{ReverseWords("  hello world!  ")}-------------------");
        }
        /// <summary>
        /// "执行用时 :↵120 ms↵, 在所有 C# 提交中击败了↵34.52%↵的用户"
        /// "内存消耗 :↵42.3 MB↵, 在所有 C# 提交中击败了↵50.00%↵的用户"
        /// </summary>
        /// <returns></returns>
        public string ReverseWords(string s)
        {
            char[] str = s.Trim().ToCharArray();
            int low = 0, high = 0;
            List<string> words = new List<string>();
            while (low < str.Length && high < str.Length)
            {
                while (low < str.Length && str[low] == ' ') low++;
                high = low;
                while (high < str.Length && str[high] != ' ') high++;
                high--;
                int pos = high;
                char[] word = new char[high - low + 1];
                for (int i = low; i < high + 1; i++)
                {
                    word[i - low] = str[i];
                }
                words.Add(new string(word));
                low = pos + 1;
            }
            string result = "";
            for (int i = 0; i < words.Count; i++)
            {
                if (i == 0)
                {
                    result += words[words.Count - 1 - i];
                }
                else
                {
                    result += " " + words[words.Count - 1 - i];
                }
            }
            return result;
        }
        /// <summary>
        /// "执行用时 :↵932 ms↵, 在所有 C# 提交中击败了↵5.95%↵的用户"
        /// "内存消耗 :↵46.5 MB↵, 在所有 C# 提交中击败了↵50.00%↵的用户"
        /// </summary>
        /// <returns></returns>
        public string ReverseWords3(string s)
        {
            char[] str = s.Trim().ToCharArray();
            int low = 0, high = 0;
            while (low < str.Length && high < str.Length)
            {
                while (low < str.Length && str[low] == ' ') low++;
                high = low;
                while (high < str.Length && str[high] != ' ') high++;
                high--;
                int pos = high;
                while (low < high)
                {
                    char temp = str[low];
                    str[low] = str[high];
                    str[high] = temp;
                    low++;
                    high--;
                }
                low = pos + 1;
            }
            string result = "";
            for (int j = str.Length - 1; j >= 0; j--)
            {
                if (str[j] == ' ')
                {
                    if (result[result.Length - 1] != ' ')
                    {
                        result += str[j];
                    }
                }
                else
                {
                    result += str[j];
                }
            }
            return result;
        }
        /// <summary>
        /// "执行用时 :↵160 ms↵, 在所有 C# 提交中击败了↵5.95%↵的用户"
        /// "内存消耗 :↵43.9 MB↵, 在所有 C# 提交中击败了↵50.00%↵的用户"
        /// </summary>
        /// <returns></returns>
        public string ReverseWords2(string s)
        {
            List<string> words = new List<string>();
            string word = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    word += s[i];
                }
                else
                {
                    if (word != "")
                    {
                        words.Add(word);
                        word = "";
                    }
                }
            }
            if (word != "")
            {
                words.Add(word);
            }
            string result = "";
            for (int i = 0; i < words.Count; i++)
            {
                if (i == 0)
                {
                    result += words[words.Count - 1 - i];
                }
                else
                {
                    result += " " + words[words.Count - 1 - i];
                }
            }
            return result;
        }
    }
}
