using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    class ProblemSet_525_连续数组 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.Failed; } }

        public void Test()
        {
            Console.WriteLine(FindMaxLength(new int[] { 0, 0, 1, 0, 0, 0, 1, 1 }));
        }

        public int FindMaxLength(int[] nums)
        {
            int MAX = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int max = 0;
                int len0 = 0, len1 = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] == 0)
                    {
                        len0++;
                    }
                    else
                    {
                        len1++;
                    }
                    if (len0 == len1)
                    {
                        max = len0 + len1;
                    }
                }
                if (max > MAX)
                {
                    MAX = max;
                }
            }
            return MAX;
        }
    }
}
