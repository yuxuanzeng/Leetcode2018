using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test331_360
{
    [TestClass]
    public class Test357
    {
        private _357CountNumbersWithUniqueDigits sol;

        [TestInitialize]
        public void setup()
        {
            sol = new _357CountNumbersWithUniqueDigits();
        }
                
        [TestMethod]
        public void TestMethod1()
        {
            var ret = sol.CountNumbersWithUniqueDigits(1);
            Assert.AreEqual(10, ret);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var ret = sol.CountNumbersWithUniqueDigits(2);
            Assert.AreEqual(91, ret);
        }
    }
}
