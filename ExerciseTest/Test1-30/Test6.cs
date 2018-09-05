using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test6
    {
        [TestMethod]
        public void Test6_1()
        {
            var sol = new _6ZigZagConversion();
            var s = "PAYPALISHIRING";
            var res = sol.Convert(s, 3);
            Assert.AreEqual("PAHNAPLSIIGYIR", res);
        }

        [TestMethod]
        public void Test6_2()
        {
            var sol = new _6ZigZagConversion();
            var s = "PAYPALISHIRING";
            var res = sol.Convert(s, 4);
            Assert.AreEqual("PINALSIGYAHRPI", res);
        }
    }
}
