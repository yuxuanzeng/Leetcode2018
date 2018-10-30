using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test47
    {
        [TestMethod]
        public void Test47_1()
        {
            var sol = new _47PermutationsII();
            var ret = sol.PermuteUnique(new int[] { 1,1,2});
            Assert.AreEqual(3, ret.Count);
        }
    }
}
