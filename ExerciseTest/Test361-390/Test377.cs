using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test361_390
{
    [TestClass]
    public class Test377
    {
        [TestMethod]
        public void Test377_1()
        {
            var sol = new _377CombinationSumIV();
            var ret = sol.CombinationSum4(new int[] { 1,2,3}, 4);
            Assert.AreEqual(7, ret);
        }
    }
}
