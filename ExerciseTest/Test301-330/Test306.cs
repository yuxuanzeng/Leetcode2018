using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test301_330
{
    [TestClass]
    public class Test306
    {
        private _306AdditiveNumber sol;

        [TestInitialize]
        public void SetUp()
        {
            sol = new _306AdditiveNumber();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var ret = sol.IsAdditiveNumber("112358");
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var ret = sol.IsAdditiveNumber("199100199");
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var ret = sol.IsAdditiveNumber("000");
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var ret = sol.IsAdditiveNumber("10");
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var ret = sol.IsAdditiveNumber("123");
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var ret = sol.IsAdditiveNumber("1023");
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var ret = sol.IsAdditiveNumber("211738");
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var ret = sol.IsAdditiveNumber("11235813213455890144");
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestMethod9()
        {
            var ret = sol.IsAdditiveNumber("1123581321345589144");
            Assert.IsTrue(ret);
        }
    }
}
