using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode
{
    public static class IEnumerableExtension
    {
        public static void Print<T>(this IEnumerable<T> source)
        {
            Console.WriteLine(string.Join(",", source));
        }
    }
}
