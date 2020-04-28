using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_067_二进制求和 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.MemoryUnqualified; } }

        public void Test()
        {
            Console.WriteLine(AddBinary("10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101", "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"));
        }

        /// <summary>
        /// "执行用时 :↵100 ms↵, 在所有 C# 提交中击败了↵83.57%↵的用户"
        /// "内存消耗 :↵25.1 MB↵, 在所有 C# 提交中击败了↵37.04%↵的用户"
        /// </summary>
        public string AddBinary(string a, string b)
        {
            if (a == "0" && b == "0")
            {
                return "0";
            }
            int lena = a.Length, lenb = b.Length;
            int carry = 0;
            string result = "";
            for (int i = 0; i < lena || i < lenb; i++)
            {
                int chra = (i < lena ? a[lena - 1 - i] : '0') - '0';
                int chrb = (i < lenb ? b[lenb - 1 - i] : '0') - '0';
                int sum = chra + chrb + carry;
                if (sum == 0)
                {
                    result = "0" + result;
                    carry = 0;
                }
                else if (sum == 1)
                {
                    result = "1" + result;
                    carry = 0;
                }
                else if (sum == 2)
                {
                    result = "0" + result;
                    carry = 1;
                }
                else
                {
                    result = "1" + result;
                    carry = 1;
                }
            }
            if (carry == 1)
            {
                result = "1" + result;
            }
            return result;
        }
    }
}
