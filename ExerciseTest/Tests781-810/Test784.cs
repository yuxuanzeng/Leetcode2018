using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test784
    {
        [TestMethod]
        public void Test784_1()
        {
            var sol = new _784LetterCasePermutation();
            var ret = sol.LetterCasePermutation("a1b2");
            Assert.AreEqual(4, ret.Count);
        }

        [TestMethod]
        public void Test784_2()
        {
            var sol = new _784LetterCasePermutation();
            var ret = sol.LetterCasePermutation("12345");
            Assert.AreEqual(1, ret.Count);
        }
    }
}
