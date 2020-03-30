using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Jinx.LeetCode.面试题
{
    public class 面试题62_圆圈中最后剩下的数字 : ISolution
    {
        public void Test()
        {
            Console.WriteLine(LastRemaining(5, 3));
            Console.WriteLine(LastRemaining(5, 1));
            Console.WriteLine(LastRemaining(70866, 116922));
        }
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
    }
}
