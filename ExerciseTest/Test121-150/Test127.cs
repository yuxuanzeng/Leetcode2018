using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test127
    {
        private _127WordLadder sol;

        [TestInitialize]
        public void SetUp()
        {
            sol = new _127WordLadder();
        }

        [TestMethod]
        public void Test127_1()
        {
            var ret = sol.LadderLength("hit", "cog",
                new List<string> { "hot", "dot", "dog", "lot", "log", "cog" });
            Assert.AreEqual(5, ret);
        }

        [TestMethod]
        public void Test127_2()
        {
            var ret = sol.LadderLength("hit", "cog",
                new List<string> { "hot", "dot", "dog", "lot", "log" });
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void Test127_3()
        {
            var ret = sol.LadderLength("hot", "dog",
                new List<string> { "hot", "dog", "cog", "pot", "dot" });
            Assert.AreEqual(3, ret);
        }
    }
}
