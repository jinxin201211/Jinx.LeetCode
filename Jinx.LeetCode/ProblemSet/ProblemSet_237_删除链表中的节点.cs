using System;
using System.Collections.Generic;
using System.Text;

namespace Jinx.LeetCode.ProblemSet
{
    public class ProblemSet_237_删除链表中的节点 : ISolution
    {
        public void Test()
        {
            ListNode root = new ListNode(4) { next = new ListNode(5) { next = new ListNode(1) { next = new ListNode(9) } } };
            root.Print();
            DeleteNode(root.next);
            root.Print();
        }

        /// <summary>
        /// 执行用时 :↵108 ms↵, 在所有 C# 提交中击败了↵89.51%↵的用户
        /// 内存消耗 :↵25.3 MB↵, 在所有 C# 提交中击败了↵8.33%↵的用户
        /// </summary>
        /// <param name="node"></param>
        public void DeleteNode(ListNode node)
        {
            while (node.next.next != null)
            {
                node.val = node.next.val;
                node = node.next;
            }
            node.val = node.next.val;
            node.next = null;
        }
    }
}
