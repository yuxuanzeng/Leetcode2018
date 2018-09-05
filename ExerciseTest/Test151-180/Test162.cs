using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test151_180
{
    [TestClass]
    public class Test162
    {
        [TestMethod]
        public void Test162_1()
        {
            var sol = new _162FindPeakElement();
            var nums = new int[] { 3,1,2,1};
            var res = sol.FindPeakElement(nums);
            if (res != 0)
            {
                Assert.AreEqual(2,res);
            }
        }

        [TestMethod]
        public void Test162_2()
        {
            var sol = new _162FindPeakElement();
            var nums = new int[] { 4,3, 1, 2, 1 };
            var res = sol.FindPeakElement(nums);
            if (res != 0)
            {
                Assert.AreEqual(3, res);
            }
        }

        [TestMethod]
        public void Test162_3()
        {
            var sol = new _162FindPeakElement();
            var nums = new int[] { 0,1,0,3,4,5,6 };
            var res = sol.FindPeakElement(nums);
            if (res != 1)
            {
                Assert.AreEqual(6, res);
            }
        }

        [TestMethod]
        public void Test162_4()
        {
            var sol = new _162FindPeakElement();
            var nums = new int[] { 1,2,3,1 };
            var res = sol.FindPeakElement(nums);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void Test162_5()
        {
            var sol = new _162FindPeakElement();
            var nums = new int[] { 1, 2, 1, 3, 5, 6, 4 };
            var res = sol.FindPeakElement(nums);
            if (res != 1)
            {
                Assert.AreEqual(5, res);
            }
        }

        [TestMethod]
        public void Test162_6()
        {
            var sol = new _162FindPeakElement();
            var nums = new int[] { 1};
            var res = sol.FindPeakElement(nums);
            Assert.AreEqual(0, res);
        }
    }
}
