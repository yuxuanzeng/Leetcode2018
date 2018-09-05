using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test211_240
{
    [TestClass]
    public class Test222
    {
        [TestMethod]
        public void Test222_1()
        {
            var sol = new _222CountCompleteTreeNodes();
            var root = TreeNodeUtils.CreateCompleteTree(
                new int[] { 1,2,3,4,5,6}
                );
            var res = sol.CountNodes(root);
            Assert.AreEqual(6, res);
        }
    }
}
