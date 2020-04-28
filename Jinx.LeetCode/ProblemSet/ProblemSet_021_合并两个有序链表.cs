using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_021_合并两个有序链表 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.MemoryUnqualified; } }

        public void Test()
        {
            ListNode l1 = new ListNode(1) { next = new ListNode(2) { next = new ListNode(5) } };
            ListNode l2 = new ListNode(1) { next = new ListNode(3) { next = new ListNode(4) } };
            l1.Print();
            l2.Print();
            MergeTwoLists(l1, l2).Print();
        }

        /// <summary>
        /// 执行用时 :↵96 ms↵, 在所有 C# 提交中击败了↵100.00%↵的用户
        /// 内存消耗 :↵25.7 MB↵, 在所有 C# 提交中击败了↵5.26%↵的用户
        /// </summary>
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode p = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    p.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    p.next = l2;
                    l2 = l2.next;
                }
                p = p.next;
            }
            if (l1 != null)
            {
                p.next = l1;
            }
            if (l2 != null)
            {
                p.next = l2;
            }
            return head.next;
        }
    }
}
