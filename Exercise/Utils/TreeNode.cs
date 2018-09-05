using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public static class TreeNodeUtils
    {
        public static TreeNode CreateCompleteTree(int[] nodes)
        {
            if (nodes == null || !nodes.Any())
            {
                return null;
            }
            var root = new TreeNode(nodes[0]);
            InsertTreeNode(root, nodes, 0);
            return root;
        }

        private static void InsertTreeNode(TreeNode root, int[] nodes, int i)
        {
            if (2 * i + 1 < nodes.Length)
            {
                root.left = new TreeNode(nodes[2*i + 1]);
                InsertTreeNode(root.left, nodes, 2*i + 1);
            }
            if (2 * i + 2 < nodes.Length)
            {
                root.right = new TreeNode(nodes[2*i + 2]);
                InsertTreeNode(root.right, nodes, 2*i + 2);
            }
        }
    }
}
