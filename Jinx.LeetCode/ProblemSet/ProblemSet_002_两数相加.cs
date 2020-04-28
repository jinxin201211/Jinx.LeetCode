using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_002_两数相加 : ISolution
    {
        public CompleteStatus Status { get { return CompleteStatus.MemoryUnqualified; } }

        public void Test()
        {
            ListNode ln1 = new ListNode(2) { next = new ListNode(4) { next = new ListNode(3) } };
            ListNode ln2 = new ListNode(5) { next = new ListNode(6) { next = new ListNode(6) { next = new ListNode(9) { next = new ListNode(9) } } } };
            AddTwoNumbers(ln1, ln2).Print();
        }

        /// <summary>
        /// "执行用时 :↵128 ms↵, 在所有 C# 提交中击败了↵69.38%↵的用户"
        /// "内存消耗 :↵27.7 MB↵, 在所有 C# 提交中击败了↵11.11%↵的用户"
        /// </summary>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode ln = new ListNode(0);
            ln.next = l1;
            int v1 = 0, v2 = 0;
            while (l1.next != null && l2.next != null)
            {
                v1 = l1.val;
                v2 = l2.val;
                l1.val = (v1 + v2 + carry) % 10;
                carry = (v1 + v2 + carry) / 10;
                l1 = l1.next;
                l2 = l2.next;
            }
            {
                v1 = l1.val;
                v2 = l2.val;
                l1.val = (v1 + v2 + carry) % 10;
                carry = (v1 + v2 + carry) / 10;
                if (l2.next != null)
                {
                    l1.next = l2.next;
                }
                if (l1.next != null)
                {
                    l1 = l1.next;
                    while (l1.next != null)
                    {
                        v1 = l1.val;
                        l1.val = (v1 + carry) % 10;
                        carry = (v1 + carry) / 10;
                        l1 = l1.next;
                    }
                    v1 = l1.val;
                    l1.val = (v1 + carry) % 10;
                    carry = (v1 + carry) / 10;
                }
            }
            if (carry != 0)
            {
                l1.next = new ListNode(carry);
            }
            return ln.next;
        }
    }
}
