using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test31_60
{
    [TestClass]
    public class Test60
    {
        [TestMethod]
        public void Test60_1()
        {
            var sol = new _60PermutationSequence();
            var ret = sol.GetPermutation(3,3);
            Assert.AreEqual("213", ret);
        }

        [TestMethod]
        public void Test60_2()
        {
            var sol = new _60PermutationSequence();
            var ret = sol.GetPermutation(4, 9);
            Assert.AreEqual("2314", ret);
        }

        [TestMethod]
        public void Test60_3()
        {
            var sol = new _60PermutationSequence();
            var ret = sol.GetPermutation(3, 1);
            Assert.AreEqual("123", ret);
        }

        [TestMethod]
        public void Test60_4()
        {
            var sol = new _60PermutationSequence();
            var ret = sol.GetPermutation(3, 6);
            Assert.AreEqual("321", ret);
        }
    }
}
