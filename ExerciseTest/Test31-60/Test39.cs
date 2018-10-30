using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test31_60
{
    [TestClass]
    public class Test39
    {
        [TestMethod]
        public void Test39_1()
        {
            var sol = new _39CombinationSum();
            var ret = sol.CombinationSum(new int[] { 2,3,6,7},7);
            Assert.AreEqual(2, ret.Count);
        }

        [TestMethod]
        public void Test39_2()
        {
            var sol = new _39CombinationSum();
            var ret = sol.CombinationSum(new int[] { 2, 3, 5 }, 8);
            Assert.AreEqual(3, ret.Count);
        }
    }
}
