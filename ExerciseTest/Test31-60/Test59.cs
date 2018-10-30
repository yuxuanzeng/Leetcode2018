using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test59
    {
        [TestMethod]
        public void Test59_1()
        {
            var sol = new _59SpiralMatrixII();
            var res = sol.GenerateMatrix(1);
            Assert.AreEqual(1, res[0,0]);
        }

        [TestMethod]
        public void Test59_2()
        {
            var sol = new _59SpiralMatrixII();
            var res = sol.GenerateMatrix(2);
            Assert.AreEqual(1, res[0, 0]);
            Assert.AreEqual(2, res[0, 1]);
            Assert.AreEqual(3, res[1, 1]);
            Assert.AreEqual(4, res[1, 0]);
        }

        [TestMethod]
        public void Test59_3()
        {
            var sol = new _59SpiralMatrixII();
            var res = sol.GenerateMatrix(3);
            Assert.AreEqual(1, res[0, 0]);
            Assert.AreEqual(2, res[0, 1]);
            Assert.AreEqual(3, res[0, 2]);
            Assert.AreEqual(4, res[1, 2]);
            Assert.AreEqual(5, res[2, 2]);
            Assert.AreEqual(6, res[2, 1]);
            Assert.AreEqual(7, res[2, 0]);
            Assert.AreEqual(8, res[1, 0]);
            Assert.AreEqual(9, res[1, 1]);
        }

        [TestMethod]
        public void Test59_4()
        {
            var sol = new _59SpiralMatrixII();
            var res = sol.GenerateMatrix(4);
            Assert.AreEqual(16, res[2,1]);
        }
    }
}
