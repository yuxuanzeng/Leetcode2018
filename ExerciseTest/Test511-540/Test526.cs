using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test511_540
{
    [TestClass]
    public class Test526
    {
        private _526BeautifulArrangement sol;

        [TestInitialize]
        public void setup()
        {
            sol = new _526BeautifulArrangement();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var ret = sol.CountArrangement(1);
            Assert.AreEqual(1, ret);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var ret = sol.CountArrangement(2);
            Assert.AreEqual(2, ret);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var ret = sol.CountArrangement(6);
            Assert.AreEqual(36, ret);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var ret = sol.CountArrangement(7);
            Assert.AreEqual(41, ret);
        }

    }
}
