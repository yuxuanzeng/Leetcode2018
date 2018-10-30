using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test131
    {
        private _131PalindromePartitioning sol;

        [TestInitialize]
        public void setup()
        {
            sol = new _131PalindromePartitioning();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var ret = sol.Partition("aab");
            Assert.AreEqual(2, ret.Count);
        }
    }
}
