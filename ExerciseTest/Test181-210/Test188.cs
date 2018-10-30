using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test181_210
{
    [TestClass]
    public class Test188
    {
        private _188BestTimeToBuyAndSellStock sol;

        [TestInitialize]
        public void setup()
        {
            sol = new _188BestTimeToBuyAndSellStock();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var ret = sol.MaxProfit(2, new int[] { 2,4,1});
            Assert.AreEqual(2, ret);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var ret = sol.MaxProfit(2, new int[] { 3, 2, 6, 5, 0, 3 });
            Assert.AreEqual(7, ret);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var ret = sol.MaxProfit(0, new int[] { 1,3 });
            Assert.AreEqual(0, ret);
        }
    }
}
