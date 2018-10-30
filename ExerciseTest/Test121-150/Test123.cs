using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test121_150
{
    [TestClass]
    public class Test123
    {
        //private _123BestTimeToBuyAndSellStock_2 sol;
        private _123BestTimeToBuyAndSellStock_3 sol;

        [TestInitialize]
        public void setup()
        {
            //sol = new _123BestTimeToBuyAndSellStock_2();
            sol = new _123BestTimeToBuyAndSellStock_3();
        }

        [TestMethod]
        public void Test123_1()
        {
            //var sol = new _123BestTimeToBuyAndSellStockIII();
            var ret = sol.MaxProfit(new int[] { 3,3,5,0,0,3,1,4});
            Assert.AreEqual(6,ret);
        }

        [TestMethod]
        public void Test123_2()
        {
            //var sol = new _123BestTimeToBuyAndSellStockIII();
            var ret = sol.MaxProfit(new int[] { 3, 3, 5, 0, 0, 3, 1, 0 });
            Assert.AreEqual(5, ret);
        }

        [TestMethod]
        public void Test123_3()
        {
            //var sol = new _123BestTimeToBuyAndSellStockIII();
            var ret = sol.MaxProfit(new int[] {1,2,3,4,5 });
            Assert.AreEqual(4, ret);
        }

        [TestMethod]
        public void Test123_4()
        {
            //var sol = new _123BestTimeToBuyAndSellStockIII();
            var ret = sol.MaxProfit(new int[] { 7,6,5,4,3,2,1 });
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void Test123_5()
        {
            //var sol = new _123BestTimeToBuyAndSellStockIII();
            var ret = sol.MaxProfit(new int[] { 6,1,3,2,4,7 });
            Assert.AreEqual(7, ret);
        }

        [TestMethod]
        public void Test123_6()
        {
            //var sol = new _123BestTimeToBuyAndSellStockIII();
            var ret = sol.MaxProfit(new int[] { 1,4,2 });
            Assert.AreEqual(3, ret);
        }

        [TestMethod]
        public void Test123_7()
        {
            //var sol = new _123BestTimeToBuyAndSellStockIII();
            var ret = sol.MaxProfit(new int[] { 1, 7,2,4 });
            Assert.AreEqual(8, ret);
        }

        [TestMethod]
        public void Test123_8()
        {
            //var sol = new _123BestTimeToBuyAndSellStockIII();
            var ret = sol.MaxProfit(new int[] { 3, 2, 6, 5, 0, 3 });
            Assert.AreEqual(7, ret);
        }

        [TestMethod]
        public void Test123_9()
        {
            //var sol = new _123BestTimeToBuyAndSellStockIII();
            var ret = sol.MaxProfit(new int[] { 6, 1, 3, 2, 4});
            Assert.AreEqual(4, ret);
        }
    }
}
