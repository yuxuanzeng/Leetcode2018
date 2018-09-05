using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseTest
{
    [TestClass]
    public class Test50
    {
        [TestMethod]
        public void Test50_1()
        {
            var sol = new _50Pow();
            var res = sol.MyPow(2.00000, 10);
            Assert.AreEqual(1024.0000, res);
        }

        [TestMethod]
        public void Test50_2()
        {
            var sol = new _50Pow();
            var res = sol.MyPow(2.10000, 3);
            Assert.AreEqual(9.261, res);
        }

        [TestMethod]
        public void Test50_3()
        {
            var sol = new _50Pow();
            var res = sol.MyPow(2.00000, -2);
            Assert.AreEqual(0.25000, res);
        }

        [TestMethod]
        public void Test50_4()
        {
            var sol = new _50Pow();
            var res = sol.MyPow(2.00000, -2147483648);
            Assert.AreEqual(0.0, res);
        }
    }
}
