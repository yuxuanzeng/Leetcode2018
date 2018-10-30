using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test212
    {
        [TestMethod]
        public void Test212_1()
        {
            var sol = new _212WordSearchII();
            var ret = sol.FindWords( new char[,] {
                { 'o','a','a','n'},
                { 'e','t','a','e'},
                { 'i','h','k','r'},
                { 'i','f','l','v'}
            }
            , new string[] { "oath", "pea", "eat", "rain" });
            Assert.AreEqual(2, ret.Count);
            Assert.AreEqual("oath", ret[0]);
            Assert.AreEqual("eat", ret[1]);
        }
    }
}
