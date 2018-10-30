using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test211_240
{
    [TestClass]
    public class Test216
    {
        [TestMethod]
        public void Test216_1()
        {
            var sol = new _216CombinationSumIII();
            var ret = sol.CombinationSum3(3,7);
            Assert.AreEqual(1,ret.Count);
        }

        [TestMethod]
        public void Test216_2()
        {
            var sol = new _216CombinationSumIII();
            var ret = sol.CombinationSum3(3, 9);
            Assert.AreEqual(3, ret.Count);
        }
    }
}
