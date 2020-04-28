using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_019_删除链表的倒数第N个节点 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.TimeUnqualified; } }

        public void Test()
        {
            ListNode node = new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) { next = new ListNode(5) { } } } } };
            RemoveNthFromEnd(node, 5).Print();
        }

        /// <summary>
        /// "执行用时 :↵108 ms↵, 在所有 C# 提交中击败了↵73.45%↵的用户"
        /// "内存消耗 :↵24.6 MB↵, 在所有 C# 提交中击败了↵100.00%↵的用户"
        /// </summary>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode p = new ListNode(-1) { next = head };
            ListNode q = p, r = p;
            while (n > 0)
            {
                q = q.next;
                n--;
            }
            while (q.next != null)
            {
                p = p.next;
                q = q.next;
            }
            p.next = p.next.next;
            return r.next;
        }
    }
}
