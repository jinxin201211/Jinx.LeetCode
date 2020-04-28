using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_287_寻找重复数 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.TimeUnqualified; } }

        public void Test()
        {
            Console.WriteLine(FindDuplicate(new int[] { 1, 3, 2, 4, 2 }));
        }

        /// <summary>
        /// "执行用时 :↵1548 ms↵, 在所有 C# 提交中击败了↵5.00%↵的用户"
        /// "内存消耗 :↵25.4 MB↵, 在所有 C# 提交中击败了↵100.00%↵的用户"
        /// </summary>
        public int FindDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return nums[i];
                    }
                }
            }
            return 0;
        }
    }
}
