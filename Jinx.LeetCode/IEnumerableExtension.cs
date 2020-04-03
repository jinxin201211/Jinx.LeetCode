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
        public static void Print(this ListNode source)
        {
            ListNode root = source;
            while (root != null)
            {
                Console.Write(root.val);
                Console.Write(" ");
                root = root.next;
            }
            Console.WriteLine();
        }
    }
}
