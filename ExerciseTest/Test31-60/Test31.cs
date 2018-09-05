using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test31_60
{
    [TestClass]
    public class Test31
    {
        [TestMethod]
        public void Test31_1()
        {
            var sol = new _32LongestValidParentheses();
            var res = sol.LongestValidParentheses(")()())");
            Assert.AreEqual(4,res);
        }
    }
}
