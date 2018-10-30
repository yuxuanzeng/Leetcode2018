using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;


namespace ExerciseTest
{
    [TestClass]
    public class Test52
    {
        [TestMethod]
        public void Test52_1()
        {
            var sol = new _52NQueensII();
            var ret = sol.TotalNQueens(4);
            Assert.AreEqual(2,ret);
        }

        [TestMethod]
        public void Test52_2()
        {
            var sol = new _52NQueensII();
            var ret = sol.TotalNQueens(5);
            Assert.AreEqual(10, ret);
        }
    }
}
