using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _25ReverseNodesInKGroup
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k == 1)
            {
                return head;
            }
            var K_1Node = head;
            var i = 0;
            for (; i < k - 1; i++)
            {
                if (K_1Node == null)
                {
                    break;
                }
                K_1Node = K_1Node.next;
            }
            var KNode = K_1Node.next;
            if (i < k - 2 || KNode == null)
            {
                return head;
            }
            var RestOfNodes = KNode.next;
            K_1Node.next = null;
            KNode.next = ReverseKGroup(head, k-1);
            var tail = KNode;
            while (tail.next != null)
            {
                tail = tail.next;
            }
            tail.next = ReverseKGroup(RestOfNodes, k);
            return KNode;
        }
    }
}
