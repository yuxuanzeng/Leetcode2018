using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test211_240
{
    [TestClass]
    public class Test240
    {
        [TestMethod]
        public void Test240_1()
        {
            var sol = new _240SearchA2DMatrixII();
            var res = sol.SearchMatrix(
                new int[,] {
                      { 1, 4, 7, 11, 15 },
                      { 2, 5, 8, 12, 19},
                      { 3, 6, 9, 16, 22},
                      { 10, 13, 14, 17, 24},
                      { 18, 21, 23, 26, 30}
                },
                5
                );
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void Test240_2()
        {
            var sol = new _240SearchA2DMatrixII();
            var res = sol.SearchMatrix(
                new int[,] {
                      { 1, 4, 7, 11, 15 },
                      { 2, 5, 8, 12, 19},
                      { 3, 6, 9, 16, 22},
                      { 10, 13, 14, 17, 24},
                      { 18, 21, 23, 26, 30}
                },
                20
                );
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test240_3()
        {
            var sol = new _240SearchA2DMatrixII();
            var res = sol.SearchMatrix(
                new int[,] {
                      { 1, 4, 7, 11, 15 },
                      { 2, 5, 8, 12, 19},
                      { 3, 6, 9, 16, 22},
                      { 10, 13, 14, 17, 24},
                      { 18, 21, 23, 26, 30}
                },
                1
                );
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test240_4()
        {
            var sol = new _240SearchA2DMatrixII();
            var res = sol.SearchMatrix(
                new int[,] {
                      { 1, 4, 7, 11, 15 },
                      { 2, 5, 8, 12, 19},
                      { 3, 6, 9, 16, 22},
                      { 10, 13, 14, 17, 24},
                      { 18, 21, 23, 26, 30}
                },
                30
                );
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test240_5()
        {
            var sol = new _240SearchA2DMatrixII();
            var res = sol.SearchMatrix(
                new int[,] {
                      { 1, 4, 7, 11, 15 },
                      { 2, 5, 8, 12, 19},
                      { 3, 6, 9, 16, 22},
                      { 10, 13, 14, 17, 24},
                      { 18, 21, 23, 26, 30}
                },
                0
                );
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test240_6()
        {
            var sol = new _240SearchA2DMatrixII();
            var res = sol.SearchMatrix(
                new int[,] {
                      { 1, 4, 7, 11, 15 },
                      { 2, 5, 8, 12, 19},
                      { 3, 6, 9, 16, 22},
                      { 10, 13, 14, 17, 24},
                      { 18, 21, 23, 26, 30}
                },
                31
                );
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test240_7()
        {
            var sol = new _240SearchA2DMatrixII();
            var res = sol.SearchMatrix(
                new int[,] {
                      { 1, 4, 7, 11, 15 },
                      { 2, 5, 8, 12, 19},
                      { 3, 6, 9, 16, 22},
                      { 10, 13, 14, 17, 24},
                      { 18, 21, 23, 26, 30}
                },
                2
                );
            Assert.IsTrue(res);
        }
    }
}
