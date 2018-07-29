using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test4
    {
        [TestMethod]
        public void Test4_1()
        {
            var sol = new _4MedianOfTwoSortedArrays();
            var nums1 = new List<int> { 1, 3 };
            var nums2 = new List<int> { 2, 4 };
            var res = sol.FindMedianSortedArrays(nums1.ToArray(), nums2.ToArray());
            Assert.AreEqual(2.5, res);
        }

        [TestMethod]
        public void Test4_2()
        {
            var sol = new _4MedianOfTwoSortedArrays();
            var nums1 = new List<int> { 1, 3 };
            var nums2 = new List<int> { 1, 1 };
            var res = sol.FindMedianSortedArrays(nums1.ToArray(), nums2.ToArray());
            Assert.AreEqual(1, res);
        }
    }
}
