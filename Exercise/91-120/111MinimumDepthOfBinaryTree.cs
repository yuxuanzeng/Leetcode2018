using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _111MinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            else if (root.left == null)
            {
                return 1 + MinDepth(root.right);
            }
            else if (root.right == null)
            {
                return 1 + MinDepth(root.left);
            }
            return Math.Min(1 + MinDepth(root.left), 1+ MinDepth(root.right));
        }
    }
}
