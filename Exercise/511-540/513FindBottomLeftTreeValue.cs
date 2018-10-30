using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _513FindBottomLeftTreeValue
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            var lastNode = root;
            var neighbors = new Queue<TreeNode>();
            neighbors.Enqueue(root);
            while (neighbors.Any())
            {
                lastNode = neighbors.First();
                var count = neighbors.Count;
                for (var i = 0; i < count; i++)
                {
                    var curNode = neighbors.Dequeue();
                    if (curNode.left != null)
                    {
                        neighbors.Enqueue(curNode.left);
                    }
                    if (curNode.right != null)
                    {
                        neighbors.Enqueue(curNode.right);
                    }
                }
            }
            return lastNode.val;
        }
    }
}
