using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test373
    {
        [TestMethod]
        public void Test373_1()
        {
            var sol = new _373FindKPairsWithSmallestSums();
            var nums1 = new int[] { 1, 7, 11 };
            var nums2 = new int[] { 2, 4, 6 };
            var res = sol.KSmallestPairs(nums1, nums2, 3);
            var expected = new List<int[]> {
                new int[] { 1,2},
                new int[] { 1,4},
                new int[] { 1,6}
            };
            //CollectionAssert.AreEquivalent(expected,(List<int[]>)res);
            Assert.AreEqual(expected.Count, res.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEquivalent(expected[i], res[i]);
            }
        }

        [TestMethod]
        public void Test373_2()
        {
            var sol = new _373FindKPairsWithSmallestSums();
            var nums1 = new int[] { 1, 1,2 };
            var nums2 = new int[] { 1,2,3 };
            var res = sol.KSmallestPairs(nums1, nums2, 2);
            var expected = new List<int[]> {
                new int[] { 1,1},
                new int[] { 1,1}
            };
            //CollectionAssert.AreEquivalent(expected,(List<int[]>)res);
            Assert.AreEqual(expected.Count, res.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEquivalent(expected[i], res[i]);
            }
        }

        [TestMethod]
        public void Test373_3()
        {
            var sol = new _373FindKPairsWithSmallestSums();
            var nums1 = new int[] { 1, 2 };
            var nums2 = new int[] { 3 };
            var res = sol.KSmallestPairs(nums1, nums2, 3);
            var expected = new List<int[]> {
                new int[] { 1,3},
                new int[] { 2,3}
            };
            //CollectionAssert.AreEquivalent(expected,(List<int[]>)res);
            Assert.AreEqual(expected.Count, res.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEquivalent(expected[i], res[i]);
            }
        }
    }
}
