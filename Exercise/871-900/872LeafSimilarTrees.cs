using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _872LeafSimilarTrees
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }
            if (root1 == null || root2 == null)
            {
                return false;
            }
            var leafValues1 = new List<int>();
            getLeafValues(root1, leafValues1);
            var leavValues2 = new List<int>();
            getLeafValues(root2, leavValues2);
            if (leafValues1.Count != leavValues2.Count)
            {
                return false;
            }
            for (var i = 0; i < leafValues1.Count; i++)
            {
                if (leafValues1[i] != leavValues2[1])
                {
                    return false;
                }
            }
            return true;
        }

        private void getLeafValues(TreeNode root, List<int> leaves)
        {
            if (root == null)
            {
                return;
            }
            if (root.left == null && root.right == null)
            {
                leaves.Add(root.val);
            }
            getLeafValues(root.left, leaves);
            getLeafValues(root.right, leaves);
        }
    }
}
