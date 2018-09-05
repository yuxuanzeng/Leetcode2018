using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _19RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var root = head;
            var length = getListLength(head);
            var index = length + 1 - n;
            if (index == 1)
            {
                return root.next;
            }
            var curNode = root;
            var prevNode = root;
            for (var i = 1; i < index; i++)
            {
                prevNode = curNode;
                curNode = curNode.next;
            }
            prevNode.next = curNode.next;

            return root;
        }

        private int getListLength(ListNode head)
        {
            //var i = 1;
            if (head.next == null)
            {
                return 1;
            }
            return 1+getListLength(head.next);
        }
    }
}
