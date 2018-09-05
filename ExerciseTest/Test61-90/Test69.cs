using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test69
    {
        [TestMethod]
        public void Test69_1()
        {
            var sol = new _69Sqrt();
            var res = sol.MySqrt(8);
            Assert.AreEqual(2,res);
        }

        [TestMethod]
        public void Test69_2()
        {
            var sol = new _69Sqrt();
            var res = sol.MySqrt(2147395599);
            Assert.AreEqual(46339, res);
        }
    }
}
