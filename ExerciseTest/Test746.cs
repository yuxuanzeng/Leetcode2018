using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test746
    {
        [TestMethod]
        public void Test746_1()
        {
            var sol = new _746MinCostClimbingStairs();
            var stairs = new List<int> { 10,15,20};
            var res = sol.MinCostClimbingStairs(stairs.ToArray());
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void Test746_2()
        {
            var sol = new _746MinCostClimbingStairs();
            var stairs = new List<int> { 10, 15 };
            var res = sol.MinCostClimbingStairs(stairs.ToArray());
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void Test746_3()
        {
            var sol = new _746MinCostClimbingStairs();
            var stairs = new List<int> { 1,100,1,1,1,100,1,1,100,1};
            var res = sol.MinCostClimbingStairs(stairs.ToArray());
            Assert.AreEqual(6, res);
        }
    }
}
