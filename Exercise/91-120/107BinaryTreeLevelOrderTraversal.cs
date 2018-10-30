using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _107BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var ret = new Stack<IList<int>>();
            if (root == null)
            {
                return ret.ToList();
            }
            var neighbors = new Queue<TreeNode>();
            neighbors.Enqueue(root);
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
                ret.Push(values);
            }
            return ret.ToList();
        }
    }
}
