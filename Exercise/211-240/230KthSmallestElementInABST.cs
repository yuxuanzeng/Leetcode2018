using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _230KthSmallestElementInABST
    {
        public int KthSmallest(TreeNode root, int k)
        {
            if (root == null)
            {
                return -1;
            }

            var lc = Count(root.left);
            if (k == lc + 1)
            {
                return root.val;
            }
            else if (k > lc + 1)
            {
                return KthSmallest(root.right, k - lc - 1);
            }
            else
            {
                return KthSmallest(root.left, k);
            }
        }

        private int Count(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + Count(root.right) + Count(root.left);
        }
    }
}
