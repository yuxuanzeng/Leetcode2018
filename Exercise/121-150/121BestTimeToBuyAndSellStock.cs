using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _121BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;
            var maxProfit = 0;
            for (var i = 1; i < prices.Length; i++)
            {
                profit = Math.Max(0, profit + prices[i] - prices[i-1]);
                maxProfit = Math.Max(maxProfit, profit);
            }

            return maxProfit;
        }
    }
}
