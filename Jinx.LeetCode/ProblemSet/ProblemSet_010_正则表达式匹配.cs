using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_010_正则表达式匹配 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.Failed; } }

        public void Test()
        {
            //Console.WriteLine(IsMatch("aa", "a"));
            Console.WriteLine(IsMatch("aa", ".*"));
            //Console.WriteLine(IsMatch("aa", "a*"));
            //Console.WriteLine(IsMatch("aa", "a*aa"));
            //Console.WriteLine(IsMatch("aa", "a*a"));
            //Console.WriteLine(IsMatch("aaba", "a*aaba"));
            //Console.WriteLine(IsMatch("aaba", "a*aba"));
            //Console.WriteLine(IsMatch("aaba", "a*ba"));
        }

        public bool IsMatch(string s, string p)
        {
            if (string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(p) || !string.IsNullOrEmpty(s) && string.IsNullOrEmpty(p))
            {
                return false;
            }
            else
            {
                int index1 = 0, index2 = 0;
                bool match = true;
                while (index1 < s.Length && index2 < p.Length)
                {
                    if (p[index2] == '.')
                    {
                        index1++;
                        index2++;
                    }
                    else if (p[index2] == '*')
                    {
                        if (p[index2 - 1] != '.' && s[index1] != p[index2 - 1])
                        {
                            match = false;
                            break;
                        }
                        else
                        {
                            int prev1 = index1;
                            while (index1 < s.Length && s[index1 - 1] == s[index1])
                            {
                                index1++;
                            }
                            char prev2 = p[index2 - 1] != '.' ? p[index2 - 1] : s[prev1];
                            int char_count = 0;
                            while (index2 < p.Length && (p[index2] == '*' || p[index2] == prev2))
                            {
                                if (p[index2] != '*')
                                {
                                    char_count++;
                                }
                                index2++;
                            }
                            if (index1 - prev1 < char_count)
                            {
                                match = false;
                                break;
                            }
                            else
                            {
                                index1++;
                                index2++;
                            }
                        }
                    }
                    else if (s[index1] == p[index2])
                    {
                        index1++;
                        index2++;
                    }
                    else
                    {
                        match = false;
                        break;
                    }
                }
                if (index1 < s.Length || index2 < p.Length)
                {
                    match = false;
                }
                return match;
            }
        }
    }
}
