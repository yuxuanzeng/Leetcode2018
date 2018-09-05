using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test9
    {
        [TestMethod]
        public void Test9_1()
        {
            var sol = new _9PalindromeNumber();
            var res = sol.IsPalindrome(121);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test9_2()
        {
            var sol = new _9PalindromeNumber();
            var res = sol.IsPalindrome(-121);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test9_3()
        {
            var sol = new _9PalindromeNumber();
            var res = sol.IsPalindrome(10);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test9_4()
        {
            var sol = new _9PalindromeNumber();
            var res = sol.IsPalindrome(0);
            Assert.IsTrue(res);
        }
    }
}
