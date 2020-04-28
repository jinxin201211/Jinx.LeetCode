using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_007_整数反转 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.Unqualified; } }

        public void Test()
        {
            //Console.WriteLine(Reverse(int.MinValue));
            Console.WriteLine(Reverse(-2147483412));
        }

        /// <summary>
        /// "执行用时 :↵76 ms↵, 在所有 C# 提交中击败了↵7.88%↵的用户"
        /// "内存消耗 :↵14.9 MB↵, 在所有 C# 提交中击败了↵11.11%↵的用户"
        /// </summary>
        public int Reverse(int x)
        {
            try
            {
                List<int> nums = new List<int>();
                while (x != 0)
                {
                    nums.Add(x % 10);
                    x /= 10;
                }
                int result = 0;
                int carry = 1;
                for (int i = nums.Count - 1; i >= 0; i--)
                {
                    result = checked(result + nums[i] * carry);
                    carry = carry * 10;
                }
                return result;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
