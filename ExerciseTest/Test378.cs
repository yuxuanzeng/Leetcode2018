using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test378
    {
        [TestMethod]
        public void Test378_1()
        {
            var sol = new _378KthSmallestEleInASortedMatrix();
            var matrix = new int[,] { { 1,5,9}, {10,11,13 }, {12,13,15 } };
            var res = sol.KthSmallest(matrix, 6);
            Assert.AreEqual(12, res);
        }
    }
}
