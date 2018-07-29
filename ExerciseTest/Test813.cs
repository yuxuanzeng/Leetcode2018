using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test813
    {
        [TestMethod]
        public void Test813_1()
        {
            var sol = new _813LargestSumOfAverages();
            var nums = new List<int>() { 9,1,2,3,9};
            var res = sol.LargestSumOfAverages(nums.ToArray(), 3);
            Assert.AreEqual(20.0, res);
        }

        [TestMethod]
        public void Test813_2()
        {
            var sol = new _813LargestSumOfAverages();
            var nums = new List<int>() { 1,2,3,4,5,6,7 };
            var res = sol.LargestSumOfAverages(nums.ToArray(), 4);
            Assert.AreEqual(20.5, res);
        }
    }
}
