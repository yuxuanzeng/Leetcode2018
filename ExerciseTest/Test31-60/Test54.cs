using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Linq;

namespace ExerciseTest
{
    [TestClass]
    public class Test54
    {
        [TestMethod]
        public void Test54_1()
        {
            var sol = new _54SpiralMatrix();
            var res = sol.SpiralOrder(new int[,] {
                { 1,2,3,4,5},
                { 6,7,8,9,10}
            });
            Assert.AreEqual(10, res.Count);
            Assert.AreEqual(1, res[0]);
            Assert.AreEqual(6, res.Last());
        }

        [TestMethod]
        public void Test54_2()
        {
            var sol = new _54SpiralMatrix();
            var res = sol.SpiralOrder(new int[,] {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9}
            });
            Assert.AreEqual(9, res.Count);
            Assert.AreEqual(1, res[0]);
            Assert.AreEqual(5, res.Last());
        }

        [TestMethod]
        public void Test54_3()
        {
            var sol = new _54SpiralMatrix();
            var res = sol.SpiralOrder(new int[,] {
                { 3},
                { 4}
            });
            Assert.AreEqual(2, res.Count);
            Assert.AreEqual(3, res[0]);
            Assert.AreEqual(4, res.Last());
        }

        [TestMethod]
        public void Test54_4()
        {
            var sol = new _54SpiralMatrix();
            var res = sol.SpiralOrder(new int[,] {
                { 3,4}
            });
            Assert.AreEqual(2, res.Count);
            Assert.AreEqual(3, res[0]);
            Assert.AreEqual(4, res.Last());
        }
    }
}
