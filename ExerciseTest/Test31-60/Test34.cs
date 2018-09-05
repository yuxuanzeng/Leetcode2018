using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test34
    {
        [TestMethod]
        public void Test34_1()
        {
            var sol = new _34FindFirstAndLastPosition();
            var res = sol.SearchRange(new List<int> { 5, 7, 7, 8, 8, 10 }.ToArray(), 7);
            Assert.AreEqual(1, res[0]);
            Assert.AreEqual(2, res[1]);
        }

        [TestMethod]
        public void Test34_2()
        {
            var sol = new _34FindFirstAndLastPosition();
            var res = sol.SearchRange(new List<int> { 5, 7, 7, 8, 8, 10 }.ToArray(), 6);
            Assert.AreEqual(-1, res[0]);
            Assert.AreEqual(-1, res[1]);
        }
    }
}
