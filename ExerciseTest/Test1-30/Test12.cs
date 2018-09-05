using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test12
    {
        [TestMethod]
        public void Test12_1()
        {
            var sol = new _12IntegerToRoman();
            var res = sol.IntToRoman(58);
            Assert.AreEqual("LVIII", res);
        }

        [TestMethod]
        public void Test12_2()
        {
            var sol = new _12IntegerToRoman();
            var res = sol.IntToRoman(1);
            Assert.AreEqual("I", res);
        }

        [TestMethod]
        public void Test12_3()
        {
            var sol = new _12IntegerToRoman();
            var res = sol.IntToRoman(3999);
            Assert.AreEqual("MMMCMXCIX", res);
        }

        [TestMethod]
        public void Test12_4()
        {
            var sol = new _12IntegerToRoman();
            var res = sol.IntToRoman(1994);
            Assert.AreEqual("MCMXCIV", res);
        }
    }
}
