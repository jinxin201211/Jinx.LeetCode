using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_004_寻找两个有序数组的中位数 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.None; } }

        public void Test()
        {
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1 }, new int[] { 2, 3, 4, 5 }));
        }

        /// <summary>
        /// "执行用时 :↵140 ms↵, 在所有 C# 提交中击败了↵85.01%↵的用户"
        /// "内存消耗 :↵27.9 MB↵, 在所有 C# 提交中击败了↵7.69%↵的用户"
        /// </summary>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if ((nums1.Length + nums2.Length) % 2 == 1)
            {
                int i = 0, j = 0, len = 0;
                int n = 0;
                while (len <= (nums1.Length + nums2.Length) / 2)
                {
                    if (i >= nums1.Length)
                    {
                        n = nums2[j];
                        j++;
                    }
                    else if (j >= nums2.Length)
                    {
                        n = nums1[i];
                        i++;
                    }
                    else if (nums1[i] < nums2[j] && i < nums1.Length)
                    {
                        n = nums1[i];
                        i++;
                    }
                    else
                    {
                        n = nums2[j];
                        j++;
                    }
                    len++;
                }
                return n;
            }
            else
            {
                int i = 0, j = 0, len = 0;
                int n1 = 0, n2 = 0;
                while (len <= (nums1.Length + nums2.Length) / 2)
                {
                    n1 = n2;
                    if (i >= nums1.Length)
                    {
                        n2 = nums2[j];
                        j++;
                    }
                    else if (j >= nums2.Length)
                    {
                        n2 = nums1[i];
                        i++;
                    }
                    else if (nums1[i] < nums2[j] && i < nums1.Length)
                    {
                        n2 = nums1[i];
                        i++;
                    }
                    else
                    {
                        n2 = nums2[j];
                        j++;
                    }
                    len++;
                }
                return (n1 + n2) / 2.0;
            }
        }
    }
}
