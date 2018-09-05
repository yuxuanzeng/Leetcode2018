using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test61_90
{
    [TestClass]
    public class Test74
    {
        [TestMethod]
        public void Test74_1()
        {
            var sol = new _74SearchA2DMatrix();
            var matrix = new int[3, 4] {
                { 1,3,5,7},
                { 10,11,16,20},
                { 23,30,34,50}
            };
            var res = sol.SearchMatrix(matrix, 3);
            Assert.IsTrue(res);
        }
    }
}
