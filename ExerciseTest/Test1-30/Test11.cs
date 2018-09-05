using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test11
    {
        [TestMethod]
        public void Test11_1()
        {
            var sol = new _11ContainerWithMostWater();
            var heights = new List<int> { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var res = sol.MaxArea(heights.ToArray());
            Assert.AreEqual(49, res);
        }

        [TestMethod]
        public void Test11_2()
        {
            var sol = new _11ContainerWithMostWater();
            var heights = new List<int> { 1, 2, 4, 3 };
            var res = sol.MaxArea(heights.ToArray());
            Assert.AreEqual(4, res);
        }
    }
}
