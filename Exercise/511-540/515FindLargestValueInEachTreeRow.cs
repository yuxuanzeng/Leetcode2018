using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _515FindLargestValueInEachTreeRow
    {
        public IList<int> LargestValues(TreeNode root)
        {
            var ret = new List<int>();
            if (root == null)
            {
                return ret;
            }
            var neighbors = new Queue<TreeNode>();
            neighbors.Enqueue(root);
            while (neighbors.Any())
            {
                var max = Int32.MinValue;
                var count = neighbors.Count;
                for (var i = 0; i < count; i++)
                {
                    var curNode = neighbors.Dequeue();
                    if (curNode.val > max)
                    {
                        max = curNode.val;
                    }
                    if (curNode.left != null)
                    {
                        neighbors.Enqueue(curNode.left);
                    }
                    if (curNode.right != null)
                    {
                        neighbors.Enqueue(curNode.right);
                    }
                }
                ret.Add(max);
            }

            return ret;
        }
    }
}
