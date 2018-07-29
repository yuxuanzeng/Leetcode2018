using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test330
    {
        [TestMethod]
        public void Test330_1()
        {
            var sol = new _330PatchingArray();
            var nums = new List<int> { 1, 2, 31, 33 };
            var res = sol.MinPatches(nums.ToArray(), 2147483647);
            Assert.AreEqual(28, res);
        }
    }
}
