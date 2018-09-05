using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _21MergeTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }

            var root = new ListNode(l1.val <= l2.val ? l1.val : l2.val);
            if (l1.val <= l2.val) l1 = l1.next;
            else l2 = l2.next;
            var curNode = root;
            while (l1 != null && l2 != null)
            {
                curNode.next = new ListNode(0);
                if (l1.val <= l2.val)
                {
                    curNode.next.val = l1.val;
                    l1 = l1.next;
                }
                else
                {
                    curNode.next.val = l2.val;
                    l2 = l2.next;
                }
                curNode = curNode.next;
            }
            if (l1 != null)
            {
                curNode.next = l1;
            }
            if (l2 != null)
            {
                curNode.next = l2;
            }
            return root;
        }
    }
}
