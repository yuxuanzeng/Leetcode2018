using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest
{
    [TestClass]
    public class Test79
    {
        [TestMethod]
        public void Test79_1()
        {
            var sol = new _79WordSearch();
            var ret = sol.Exist(new char[,] {
                { 'A', 'B', 'C', 'E' },
                { 'S','F','C','S'},
                { 'A','D','E','E'}
            }
            ,"ABCCED");
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void Test79_2()
        {
            var sol = new _79WordSearch();
            var ret = sol.Exist(new char[,] {
                { 'A', 'B', 'C', 'E' },
                { 'S','F','C','S'},
                { 'A','D','E','E'}
            }
            , "SEE");
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void Test79_3()
        {
            var sol = new _79WordSearch();
            var ret = sol.Exist(new char[,] {
                { 'A', 'B', 'C', 'E' },
                { 'S','F','C','S'},
                { 'A','D','E','E'}
            }
            , "ABCB");
            Assert.IsFalse(ret);
        }

    }
}
