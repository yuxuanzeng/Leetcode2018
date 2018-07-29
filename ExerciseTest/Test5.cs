using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test5
    {
        [TestMethod]
        public void Test5_1()
        {
            var sol = new _5LongestPalindromicSubstring();
            var s = "babad";
            var res = sol.LongestPalindrome(s);
            Assert.AreEqual("bab", res);
        }

        [TestMethod]
        public void Test5_2()
        {
            var sol = new _5LongestPalindromicSubstring();
            var s = "baa";
            var res = sol.LongestPalindrome(s);
            Assert.AreEqual("aa", res);
        }
    }
}
