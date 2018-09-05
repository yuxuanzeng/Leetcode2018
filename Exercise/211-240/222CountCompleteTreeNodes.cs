using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _222CountCompleteTreeNodes
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var h = CountHeight(root);
            var rh = CountHeight(root.right);
            if (rh == h - 1)
            {
                var r1 = 1 << (h - 1);
                var r2 = CountNodes(root.right);
                return r1 + r2;
            }
            else
            {
                var r1 = 1 << (h - 2);
                var r2 = CountNodes(root.left);
                return  r1+ r2;
            }
        }

        private int CountHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + CountHeight(root.left);
        }
    }
}
