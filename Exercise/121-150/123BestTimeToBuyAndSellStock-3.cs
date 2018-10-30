using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _123BestTimeToBuyAndSellStock_3
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || !prices.Any())
            {
                return 0;
            }

            var buy1 = -prices[0];
            //var sell1 = Int32.MinValue;
            var buy2 = Int32.MinValue;
            //var sell2 = Int32.MinValue;
            var sell1 = 0;
            //var buy2 = 0;
            var sell2 = 0;
            for (var i = 1; i < prices.Length; i++)
            {
                buy1 = Math.Max(buy1, -prices[i]);
                sell1 = Math.Max(sell1, buy1 + prices[i]);
                buy2 = Math.Max(buy2, sell1 - prices[i]);
                sell2 = Math.Max(sell2, buy2 + prices[i]);
            }
            return sell2;
        }
    }
}
