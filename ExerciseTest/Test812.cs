using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test812
    {
        [TestMethod]
        public void Test812_1()
        {
            var sol = new _812LargestTriangleArea();
            var p = new int[5][];
            p[0] = new int[] { 2,5};
            p[1] = new int[] { 7, 7 };
            p[2] = new int[] { 10,8};
            p[3] = new int[] { 10,10};
            p[4] = new int[] { 1,1};
            var res = sol.LargestTriangleArea(p);
            Assert.AreEqual(14.5, res);
        }

        [TestMethod]
        public void Test812_2()
        {
            var sol = new _812LargestTriangleArea();
            var p = new int[5][];
            p[0] = new int[] { 1,10};
            p[1] = new int[] { 3, 9 };
            p[2] = new int[] { 7,6};
            p[3] = new int[] { 9,0};
            p[4] = new int[] { 10,0};
            var res = sol.LargestTriangleArea(p);
            Assert.AreEqual(14.0, res);
        }
    }
}
