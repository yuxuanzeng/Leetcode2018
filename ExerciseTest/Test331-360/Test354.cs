using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test354
    {
        [TestMethod]
        public void Test354_1()
        {
            var sol = new _354RussionDollEnvelopes();
            var res = sol.MaxEnvelopes(new int[,] { { 5, 4 }, { 6, 4 }, { 6, 7 }, { 2, 3 } });
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void Test354_2()
        {
            var sol = new _354RussionDollEnvelopes();
            var res = sol.MaxEnvelopes(new int[,] { { 5, 4 }});
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Test354_3()
        {
            var sol = new _354RussionDollEnvelopes();
            var res = sol.MaxEnvelopes(new int[,] { });
            Assert.AreEqual(0, res);
        }
    }
}
