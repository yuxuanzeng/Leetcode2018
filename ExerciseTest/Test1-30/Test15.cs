using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test15
    {
        [TestMethod]
        public void Test15_1()
        {
            var sol = new _15ThreeSum();
            var nums = new List<int>() { -1, 0, 1, 2, -1, -4 };
            var res = sol.ThreeSum(nums.ToArray());
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void Test15_2()
        {
            var sol = new _15ThreeSum();
            var nums = new List<int>() { 0,0,0,0 };
            var res = sol.ThreeSum(nums.ToArray());
            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        public void Test15_3()
        {
            var sol = new _15ThreeSum();
            var nums = new List<int>() { -2, 0, 0, 2, 2 };
            var res = sol.ThreeSum(nums.ToArray());
            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        public void Test15_4()
        {
            var sol = new _15ThreeSum();
            var nums = new List<int>() { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 };
            var res = sol.ThreeSum(nums.ToArray());
            Assert.AreEqual(6, res.Count);
        }
    }
}
