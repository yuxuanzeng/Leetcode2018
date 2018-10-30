using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace ExerciseTest.Test691_720
{
    [TestClass]
    public class Test714
    {
        [TestMethod]
        public void Test714_1()
        {
            var sol = new _714BestTimeToBuyAndSellStockWithTransactionFee();
            var ret = sol.MaxProfit(new int[] { 1, 3, 2, 8, 4, 9 }, 2);
            Assert.AreEqual(8, ret);
        }

        [TestMethod]
        public void Test714_2()
        {
            var sol = new _714BestTimeToBuyAndSellStockWithTransactionFee();
            var ret = sol.MaxProfit(new int[] { 564, 3277, 2988, 2460, 3213, 4445 }, 655);
            Assert.AreEqual(3388, ret);
        }

        [TestMethod]
        public void Test714_3()
        {
            var sol = new _714BestTimeToBuyAndSellStockWithTransactionFee();
            var ret = sol.MaxProfit(new int[] { 1,2 }, 0);
            Assert.AreEqual(1, ret);
        }

        [TestMethod]
        public void Test714_4()
        {
            var sol = new _714BestTimeToBuyAndSellStockWithTransactionFee();
            var ret = sol.MaxProfit(new int[] { 66, 19, 947, 932, 3244, 3374, 1910, 2561, 3466, 4104,
                1667, 589, 3048, 730, 1770, 1241, 2270, 4016, 2835, 604, 4771, 514, 3854, 3427, 1875, 2038, 3067,
                3216, 4732, 3735, 4440, 2855, 4958, 4569, 1685, 3539, 4589, 3512, 3143, 898, 3004, 3072, 2573,
                3163, 2522, 3927, 330, 3874, 363, 1900, 1629, 1156, 4259, 2747,
                3445, 4513, 2867, 52, 3870, 1761, 619, 3308, 4380, 1101, 2592, 4852, 4140, 174, 3997, 4617, 3500,
                3028, 907, 2355, 759, 374, 2429, 412, 2132, 3973, 3583, 3028, 2070, 2235, 2659, 1053,
                2558, 753, 1221, 1185, 2225, 1593, 3554, 3703, 332, 2843, 3349, 3871, 4389, 6, 2768, 4382, 902,
                417, 191, 2107, 2838, 4958 },
                655);
            Assert.AreEqual(63156, ret);
        }
    }
}
