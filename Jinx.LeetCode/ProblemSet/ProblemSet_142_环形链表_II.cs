using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_142_环形链表_II : ISolution
    {
        public void Test()
        {
            //ListNode n1 = new ListNode(3);
            //ListNode n2 = new ListNode(2);
            //ListNode n3 = new ListNode(0);
            //ListNode n4 = new ListNode(-4);
            //n1.next = n2;
            //n2.next = n3;
            //n3.next = n4;
            //n4.next = n2;
            //DetectCycle(n1).Print();
            ListNode n1 = new ListNode(3);
            DetectCycle(n1).Print();
        }
        public ListNode DetectCycle(ListNode head)
        {
            List<ListNode> lln = new List<ListNode>();
            while (head != null)
            {
                lln.Add(head);
                if (lln.Contains(head.next))
                {
                    break;
                }
                else
                {
                    head = head.next;
                }
            }
            return head == null ? null : head.next;
        }
    }
}
