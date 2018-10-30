using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _103BinaryTreeZigzagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var ret = new List<IList<int>>();
            if (root == null)
            {
                return ret;
            }
            var neighbors = new Queue<TreeNode>();
            neighbors.Enqueue(root);
            var reverse = false;
            while (neighbors.Any())
            {
                var values = new List<int>();
                var count = neighbors.Count;
                for (var i = 0; i < count; i++)
                {
                    var curNode = neighbors.Dequeue();
                    values.Add(curNode.val);
                    if (curNode.left != null)
                    {
                        neighbors.Enqueue(curNode.left);
                    }
                    if (curNode.right != null)
                    {
                        neighbors.Enqueue(curNode.right);
                    }
                }
                if (reverse)
                {
                    values.Reverse();
                }
                reverse = !reverse;
                ret.Add(values);
            }
            return ret;
        }
    }
}
