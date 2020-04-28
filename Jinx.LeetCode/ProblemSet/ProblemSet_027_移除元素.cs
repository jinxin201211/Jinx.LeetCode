using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_027_移除元素 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.Unqualified; } }

        public void Test()
        {
            int[] nums = { 3, 2, 2, 3 };
            Console.WriteLine(RemoveElement(ref nums, 3));
            nums.Print<int>();
            nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            Console.WriteLine(RemoveElement(ref nums, 2));
            nums.Print<int>();
        }

        /// <summary>
        /// "执行用时 :↵356 ms↵, 在所有 C# 提交中击败了↵11.23%↵的用户"
        /// "内存消耗 :↵30.3 MB↵, 在所有 C# 提交中击败了↵20.00%↵的用户"
        /// </summary>
        public int RemoveElement(ref int[] nums, int val)
        {
            int index1 = -1, index2 = 0;
            while (index2 < nums.Length)
            {
                if (nums[index2] != val)
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
