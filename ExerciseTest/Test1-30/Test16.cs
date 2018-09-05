using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test16
    {
        [TestMethod]
        public void Test16_1()
        {
            var sol = new _16ThreeSumClosest();
            var nums = new List<int>() { -1, 2, 1, -4 };
            var res = sol.ThreeSumClosest(nums.ToArray(), 1);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void Test16_2()
        {
            var sol = new _16ThreeSumClosest();
            var nums = new List<int>() { 0,2,1,-3 };
            var res = sol.ThreeSumClosest(nums.ToArray(), 1);
            Assert.AreEqual(0, res);
        }
    }
}
