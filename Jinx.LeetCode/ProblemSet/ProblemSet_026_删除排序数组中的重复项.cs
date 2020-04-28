using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_026_删除排序数组中的重复项 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.Unqualified; } }

        public void Test()
        {
            int[] nums = { 1, 1, 3 };
            Console.WriteLine(RemoveDuplicates(ref nums));
            nums.Print<int>();
            nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(ref nums));
            nums.Print<int>();
            nums = new int[] { 0 };
            Console.WriteLine(RemoveDuplicates(ref nums));
            nums.Print<int>();
            nums = new int[] { };
            Console.WriteLine(RemoveDuplicates(ref nums));
            nums.Print<int>();
        }

        /// <summary>
        /// "执行用时 :↵356 ms↵, 在所有 C# 提交中击败了↵26.93%↵的用户"
        /// "内存消耗 :↵33.3 MB↵, 在所有 C# 提交中击败了↵11.11%↵的用户"
        /// </summary>
        public int RemoveDuplicates(ref int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int index1 = 0, index2 = 1;
            while (index2 < nums.Length)
            {
                if (nums[index1] != nums[index2])
                {
                    index1++;
                    nums[index1] = nums[index2];
                }
                index2++;
            }
            return index1 + 1;
        }
    }
}
