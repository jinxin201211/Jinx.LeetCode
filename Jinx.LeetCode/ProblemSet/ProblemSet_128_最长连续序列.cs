using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_128_最长连续序列 : ISolution
    {
        public void Test()
        {
            Console.WriteLine(LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 }));
            //Console.WriteLine(LongestConsecutive(new int[] { 0, -1 }));
            Console.WriteLine(LongestConsecutive(new int[] { 2147483646, -2147483647, 0, 2, 2147483644, -2147483645, 2147483645 }));
        }
        public int LongestConsecutive(int[] nums)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            List<int> numbers = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numbers.Contains(nums[i]))
                {
                    numbers.Add(nums[i]);
                }
                if (nums[i] > max) max = nums[i];
                if (nums[i] < min) min = nums[i];
            }
            int longest = 0;
            int length = 0;
            for (int i = min; i <= max; i++)
            {
                if (numbers.Contains(i))
                {
                    length++;
                }
                else
                {
                    if (length > longest)
                    {
                        longest = length;
                    }
                    length = 0;
                }
            }
            if (length > longest)
            {
                longest = length;
            }
            return longest;
        }
    }
}
