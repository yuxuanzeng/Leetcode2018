using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest.Test151_180
{
    [TestClass]
    public class Test152
    {
        private _152MaximumProductSubarray sol;

        [TestInitialize]
        public void SetUp()
        {
            sol = new _152MaximumProductSubarray();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var ret = sol.MaxProduct(new int[] {2,3,-2,4 });
            Assert.AreEqual(6, ret);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var ret = sol.MaxProduct(new int[] { 2, 3, -2, 4, 3 });
            Assert.AreEqual(12, ret);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var ret = sol.MaxProduct(new int[] { 2, 3, -2, 4 , -2});
            Assert.AreEqual(96, ret);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var ret = sol.MaxProduct(new int[] { -2,0,-1});
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var ret = sol.MaxProduct(new int[] { -2, 0, -1,2 });
            Assert.AreEqual(2, ret);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var ret = sol.MaxProduct(new int[] { -2, 0, -1, -3 });
            Assert.AreEqual(3, ret);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var ret = sol.MaxProduct(new int[] { 0 });
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var ret = sol.MaxProduct(new int[] { -1,-1 });
            Assert.AreEqual(1, ret);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var ret = sol.MaxProduct(new int[] { -4,-3,-2 });
            Assert.AreEqual(12, ret);
        }

        [TestMethod]
        public void TestMethod10()
        {
            var ret = sol.MaxProduct(new int[] { 2, -5, -2, -4, 3 });
            Assert.AreEqual(24, ret);
        }
    }
}
