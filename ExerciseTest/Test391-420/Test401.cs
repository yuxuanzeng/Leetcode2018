using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test401
    {
        private _401BinaryWatch sol;
        [TestInitialize]
        public void SetUp()
        {
            sol = new _401BinaryWatch();
        }

        [TestMethod]
        public void Test401_1()
        {
            var ret = sol.ReadBinaryWatch(1);
            Assert.AreEqual(10, ret.Count);
            Assert.IsTrue(ret.Contains("1:00"));
            Assert.IsTrue(ret.Contains("2:00"));
            Assert.IsTrue(ret.Contains("4:00"));
            Assert.IsTrue(ret.Contains("8:00"));
            Assert.IsTrue(ret.Contains("0:01"));
            Assert.IsTrue(ret.Contains("0:02"));
            Assert.IsTrue(ret.Contains("0:04"));
            Assert.IsTrue(ret.Contains("0:08"));
            Assert.IsTrue(ret.Contains("0:16"));
            Assert.IsTrue(ret.Contains("0:32"));

        }

        [TestMethod]
        public void Test401_2()
        {
            var ret = sol.ReadBinaryWatch(7);
            Assert.AreEqual(48, ret.Count);
        }
    }
}
