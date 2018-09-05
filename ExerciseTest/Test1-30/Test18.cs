using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test18
    {
        [TestMethod]
        public void Test18_1()
        {
            var sol = new _18FourSum();
            var nums = new List<int>() {-3, -2, -1, 0, 0, 1, 2, 3};
            var res = sol.FourSum(nums.ToArray(), 0);
            Assert.AreEqual(8, res.Count);
        }
    }
}
