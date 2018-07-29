using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test508
    {
        [TestMethod]
        public void Test508_1()
        {
            var root = new TreeNode(5);
            root.right = new TreeNode(-5);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(5);
            root.left.right = new TreeNode(-5);
            var sol = new _508MostFrequentSubtreeSum();
            var res = sol.FindFrequentTreeSum(root);
            CollectionAssert.AreEqual(new int[] { -5,2 }, res);
        }

        [TestMethod]
        public void Test508_2()
        {
            TreeNode root = null;
            var sol = new _508MostFrequentSubtreeSum();
            var res = sol.FindFrequentTreeSum(root);
            CollectionAssert.AreEqual(new int[] { }, res);
        }
    }
}
