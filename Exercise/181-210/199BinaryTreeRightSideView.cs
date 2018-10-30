using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _199BinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
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
                var count = neighbors.Count;
                var rightNode = neighbors.First();
                ret.Add(rightNode.val);
                for (var i = 0; i < count; i++)
                {
                    var curNode = neighbors.Dequeue();
                    if (curNode.right != null)
                    {
                        neighbors.Enqueue(curNode.right);
                    }
                    if (curNode.left != null)
                    {
                        neighbors.Enqueue(curNode.left);
                    }
                }
            }
            return ret;
        }
    }
}
