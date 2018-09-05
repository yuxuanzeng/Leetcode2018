using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test151_180
{
    [TestClass]
    public class Test153
    {
        [TestMethod]
        public void Test153_1()
        {
            var sol = new _153FindMinimuminRotatedSortedArray();
            var nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            var res = sol.FindMin(nums);
            Assert.AreEqual(0,res);
        }
    }
}
