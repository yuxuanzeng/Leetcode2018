using System;

namespace Exercise
{
    public class _543DiameterOfBinaryTree
    {
        public int DiameterOfBinaryTree(TreeNode root) {
            if (root == null) {
                return 0;
            }
            if (root.right == null) {
                return height(root.left) + 1;
            }
            if (root.left == null) {
                return height(root.right) + 1;
            }

            var dRoot = height(root.left) + height(root.right) + 2;

            return Math.Max(dRoot, Math.Max(DiameterOfBinaryTree(root.right), DiameterOfBinaryTree(root.left)));
        }

        public int height(TreeNode root) {
            if (root == null) {
                return -1;
            }
            if (root.left == null) {
                return height(root.right) + 1;
            }
            if (root.right == null) {
                return height(root.left) + 1;
            }
            return Math.Max(height(root.right), height(root.left)) + 1;
        }

    }
}
