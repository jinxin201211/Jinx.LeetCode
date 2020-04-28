using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Jinx.LeetCode.面试题
{
    public class 面试题62_圆圈中最后剩下的数字 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.Excellent; } }

        public void Test()
        {
            Console.WriteLine(LastRemaining2(5, 3));
            Console.WriteLine(LastRemaining2(5, 1));
            Console.WriteLine(LastRemaining2(70866, 116922));
        }

        /// <summary>
        /// 超出时间限制
        /// </summary>
        public int LastRemaining(int n, int m)
        {
            int[] arr = Enumerable.Range(0, n).ToArray();

            int i = -1, r = 0;
            do
            {
                for (int j = 0; j < m; j++)
                {
                    i = (i + 1) % n;
                    if (arr[i] == -1)
                    {
                        j--;
                    }
                }
                arr[i] = -1;
                r++;
            } while (r < n - 1);
            for (int j = 0; j < m; j++)
            {
                i = (i + 1) % n;
                if (arr[i] == -1)
                {
                    j--;
                }
            }
            return arr[i];
        }

        /// <summary>
        /// 执行用时 :52 ms, 在所有 C# 提交中击败了95.65%的用户
        /// 内存消耗 :14.5 MB, 在所有 C# 提交中击败了100.00%的用户
        /// </summary>
        public int LastRemaining2(int n, int m)
        {
            int p = 0;
            for (int i = 2; i <= n; i++)
            {
                p = (p + m) % i;
            }
            return p + 1;
        }
    }
}
