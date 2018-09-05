using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test211_240
{
    [TestClass]
    public class Test220
    {
        [TestMethod]
        public void Test220_1()
        {
            var sol = new _220ContainsDuplicateIII();
            var res = sol.ContainsNearbyAlmostDuplicate(
                new int[] { 1,2,3,1 },
                3,0
                );
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test220_2()
        {
            var sol = new _220ContainsDuplicateIII();
            var res = sol.ContainsNearbyAlmostDuplicate(
                new int[] { 1, 0, 1, 1 },
                1, 2
                );
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test220_3()
        {
            var sol = new _220ContainsDuplicateIII();
            var res = sol.ContainsNearbyAlmostDuplicate(
                new int[] { 1, 5,9,1,5,9 },
                2,3
                );
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test220_4()
        {
            var sol = new _220ContainsDuplicateIII();
            var res = sol.ContainsNearbyAlmostDuplicate(
                new int[] { -1, 2147483647 },
                1,
                2147483647
                );
            Assert.IsFalse(res);
        }
    }
}
