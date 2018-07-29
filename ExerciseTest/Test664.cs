using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test664_1()
        {
            var sol = new _664StrangePrinter();
            var res = sol.StrangePrinter("tgbtbg");
            Assert.AreEqual(4, res);
        }
    }
}
