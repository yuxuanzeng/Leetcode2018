using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test45
    {
        [TestMethod]
        public void Test45_1()
        {
            var sol = new _45JumpGameII();
            var res = sol.Jump(new int[] { 2,3,1,1,4});
            Assert.AreEqual(2,res);
        }

        [TestMethod]
        public void Test45_2()
        {
            var sol = new _45JumpGameII();
            var res = sol.Jump(new int[] { 3,2,1});
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Test45_3()
        {
            var sol = new _45JumpGameII();
            var res = sol.Jump(new int[] { 1,2,3 });
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void Test45_4()
        {
            var sol = new _45JumpGameII();
            var res = sol.Jump(new int[] { 2, 1});
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Test45_5()
        {
            var sol = new _45JumpGameII();
            var res = sol.Jump(new int[] { 2, 3, 1 });
            Assert.AreEqual(1, res);
        }
    }
}
