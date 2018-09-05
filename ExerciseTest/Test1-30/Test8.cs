using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test8
    {
        [TestMethod]
        public void Test8_1()
        {
            var sol = new _8StringToInteger();
            var res = sol.MyAtoi("42");
            Assert.AreEqual(42, res);
        }

        [TestMethod]
        public void Test8_2()
        {
            var sol = new _8StringToInteger();
            var res = sol.MyAtoi("4193 with words");
            Assert.AreEqual(4193, res);
        }
        [TestMethod]
        public void Test8_3()
        {
            var sol = new _8StringToInteger();
            var res = sol.MyAtoi("words and 987");
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test8_4()
        {
            var sol = new _8StringToInteger();
            var res = sol.MyAtoi("-91283472332");
            Assert.AreEqual(-2147483648, res);
        }
        [TestMethod]
        public void Test8_5()
        {
            var sol = new _8StringToInteger();
            var res = sol.MyAtoi("2147483648");
            Assert.AreEqual(2147483647, res);
        }
        [TestMethod]
        public void Test8_6()
        {
            var sol = new _8StringToInteger();
            var res = sol.MyAtoi("  0000000000012345678");
            Assert.AreEqual(12345678, res);
        }
    }
}
