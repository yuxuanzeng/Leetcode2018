using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test35
    {
        [TestMethod]
        public void Test35_1()
        {
            var sol = new _35SearchInsertPositioin();
            var res = sol.SearchInsert(new List<int> { 1,3,5,6 }.ToArray(), 2);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Test35_2()
        {
            var sol = new _35SearchInsertPositioin();
            var res = sol.SearchInsert(new List<int> { 1, 3, 5, 6 }.ToArray(), 5);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void Test35_3()
        {
            var sol = new _35SearchInsertPositioin();
            var res = sol.SearchInsert(new List<int> { 1, 3, 5, 6 }.ToArray(), 6);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void Test35_4()
        {
            var sol = new _35SearchInsertPositioin();
            var res = sol.SearchInsert(new List<int> { 1, 3, 5, 6 }.ToArray(), 1);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void Test35_5()
        {
            var sol = new _35SearchInsertPositioin();
            var res = sol.SearchInsert(new List<int> { 1, 3, 5, 6 }.ToArray(), 0);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void Test35_6()
        {
            var sol = new _35SearchInsertPositioin();
            var res = sol.SearchInsert(new List<int> { 1, 3, 5, 6 }.ToArray(), 7);
            Assert.AreEqual(4, res);
        }
    }
}
