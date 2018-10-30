using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _122BestTimeToBuyAndSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;
            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] - prices[i - 1] > 0)
                {
                    profit += prices[i] - prices[i - 1];
                }
            }
            return profit;
        }
    }
}
