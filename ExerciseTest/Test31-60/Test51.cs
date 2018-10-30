using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test51
    {
        [TestMethod]
        public void Test51_1()
        {
            var sol = new _51NQueens();
            var ret = sol.SolveNQueens(4);
            Assert.AreEqual(2, ret.Count);
        }

        [TestMethod]
        public void Test51_2()
        {
            var sol = new _51NQueens();
            var ret = sol.SolveNQueens(5);
            Assert.AreEqual(10, ret.Count);
        }
    }
}
