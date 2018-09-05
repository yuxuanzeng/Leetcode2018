using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public static class ListNodeUtils
    {
        public static ListNode generateList(List<int> nums)
        {
            if (nums == null || nums.Count() <= 0)
            {
                return null;
            }
            var root = new ListNode(nums[0]);
            var temp = root;
            for (var i = 1; i < nums.Count; i++)
            {
                temp.next = new ListNode(nums[i]);
                temp = temp.next;
            }
            return root;
        }
    }
}
