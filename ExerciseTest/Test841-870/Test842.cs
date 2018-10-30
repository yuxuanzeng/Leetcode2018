using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test841_870
{
    [TestClass]
    public class Test842
    {
        private _842SplitArrayIntoFibonacciSequence sol;

        [TestInitialize]
        public void setup()
        {
            sol = new _842SplitArrayIntoFibonacciSequence();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var ret = sol.SplitIntoFibonacci("123456579");
            Assert.AreEqual(3, ret.Count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var ret = sol.SplitIntoFibonacci("11235813");
            Assert.AreEqual(7, ret.Count);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var ret = sol.SplitIntoFibonacci("112358130");
            Assert.AreEqual(0, ret.Count);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var ret = sol.SplitIntoFibonacci("0123");
            Assert.AreEqual(0, ret.Count);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var ret = sol.SplitIntoFibonacci("1101111");
            if (ret.Count != 3)
            {
                Assert.AreEqual(4, ret.Count);
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            var ret = sol.SplitIntoFibonacci("10");
            Assert.AreEqual(0, ret.Count);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var ret = sol.SplitIntoFibonacci("000");
            Assert.AreEqual(3, ret.Count);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var ret = sol.SplitIntoFibonacci("1203");
            Assert.AreEqual(0, ret.Count);
        }
    }
}
