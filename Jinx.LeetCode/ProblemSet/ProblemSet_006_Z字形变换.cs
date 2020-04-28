using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_006_Z字形变换 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.Excellent; } }

        public void Test()
        {
            //Console.WriteLine(Convert2("LEETCODEISHIRING", 3));
            //Console.WriteLine(Convert2("LEETCODEISHIRING", 4));
            //Console.WriteLine(Convert2("PAYPALISHIRING", 4));
            Console.WriteLine(Convert("ABCDEFGHJIKL", 1));
        }

        /// <summary>
        /// "执行用时 :↵112 ms↵, 在所有 C# 提交中击败了↵81.47%↵的用户"
        /// "内存消耗 :↵26.4 MB↵, 在所有 C# 提交中击败了↵100.00%↵的用户"
        /// </summary>
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            char[] newarr = new char[s.Length];
            int index = 0;
            for (int i = 0; i < numRows; i++)
            {
                int group = 0;
                while (index < s.Length)
                {
                    if (group == 0)
                    {
                        if (i < s.Length)
                        {
                            newarr[index] = s[i];
                            index++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        int index2 = group * (numRows - 1) * 2;
                        if (i == 0)
                        {
                            if (index2 < s.Length)
                            {
                                newarr[index] = s[index2];
                                index++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (i == numRows - 1)
                        {
                            if (index2 + i < s.Length)
                            {
                                newarr[index] = s[index2 + i];
                                index++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (index2 - i < s.Length)
                            {
                                newarr[index] = s[index2 - i];
                                index++;
                            }
                            else
                            {
                                break;
                            }
                            if (index2 + i < s.Length)
                            {
                                newarr[index] = s[index2 + i];
                                index++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    group++;
                }
            }
            return new string(newarr);
        }
    }
}
