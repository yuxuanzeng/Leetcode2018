using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test241DiffWaysToCompute
    {
        [TestMethod]
        public void Test241DiffWaysToCompute1()
        {
            var sol = new Exercise._241DiffWaysToCompute();
            var res = new List<int>(sol.DiffWaysToCompute("2-1-1"));
            res.Sort();
            var expected = new List<int>() { 0,2 };
            expected.Sort();
            CollectionAssert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test241DiffWaysToCompute2()
        {
            var sol = new Exercise._241DiffWaysToCompute();
            var res = new List<int>(sol.DiffWaysToCompute("2*3-4*5"));
            res.Sort();
            var expected = new List<int>() { -34, -14, -10, -10, 10 };
            expected.Sort();
            CollectionAssert.AreEqual(expected, res);
        }
    }
}
