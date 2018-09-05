using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _24SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) return null;

            var n1 = head;
            var n2 = head.next;
            if (n2 == null) return n1;

            var restOfTheNodes = n2.next;
            n2.next = n1;
            n1.next = SwapPairs(restOfTheNodes);
            return n2;
        }
    }
}
