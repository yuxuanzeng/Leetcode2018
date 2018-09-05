using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
namespace ExerciseTest
{
    [TestClass]
    public class Test17
    {
        [TestMethod]
        public void Test17_1()
        {
            var sol = new _17LetterCombinationsOfAPhoneNumber();
            var digits = "23";
            var res = sol.LetterCombinations(digits);
            Assert.AreEqual(9, res.Count);
        }
    }
}
