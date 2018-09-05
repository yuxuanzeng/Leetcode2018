using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _23MergeKSortedList
    {
        public class NodeVal : IComparable
        {
            public int index { get; set; }
            public int val { get; set; }
            public NodeVal(int i, int v)
            {
                index = i;
                val = v;
            }

            public int CompareTo(object obj)
            {
                var that = (NodeVal)obj;
                if (this.val == that.val) {
                    return this.index - that.index;
                }
                return this.val - that.val;
            }
        }
        public ListNode MergeKLists(ListNode[] lists)
        {
            var root = new ListNode(0);
            var res = root;
            //var num = lists.Length;
            var reachEndLists = 0;
            var smallValues = new SortedSet<NodeVal>();
            for (var i = 0; i < lists.Length; i++)
            {
                if (lists[i] == null)
                {
                    reachEndLists++;
                    continue;
                }
                smallValues.Add(new NodeVal(i, lists[i].val));
                lists[i] = lists[i].next;
            }
            if (smallValues.Count <= 0)
            {
                return null;
            }
            while (reachEndLists < lists.Length)
            {
                var smallest = smallValues.Min;
                res.next = new ListNode(smallest.val);
                res = res.next;
                smallValues.Remove(smallest);
                if (lists[smallest.index] != null)
                {
                    smallValues.Add(new NodeVal(smallest.index, lists[smallest.index].val));
                    lists[smallest.index] = lists[smallest.index].next;
                }
                else
                {
                    reachEndLists++;
                }
            }
            return root.next;
        }
    }
}
