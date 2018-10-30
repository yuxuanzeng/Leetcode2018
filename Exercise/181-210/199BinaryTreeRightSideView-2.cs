using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _199BinaryTreeRightSideView_2
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var ret = new List<int>();
            RightSide(root, ret, 0);
            return ret;
        }

        private void RightSide(TreeNode root, List<int> ret, int dep)
        {
            if (root == null)
            {
                return;
            }
            if (ret.Count == dep)
            {
                ret.Add(root.val);
            }
            RightSide(root.right, ret, dep + 1);
            RightSide(root.left, ret, dep + 1);
        }
    }
}
