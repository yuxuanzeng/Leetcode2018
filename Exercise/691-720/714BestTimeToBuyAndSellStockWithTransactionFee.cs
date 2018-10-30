using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _714BestTimeToBuyAndSellStockWithTransactionFee
    {
        public int MaxProfit(int[] prices, int fee)
        {
            var profit = 0;
            var maxProfit = 0;
            var neg = 0;
            var totalProfit = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                var delta = prices[i] - prices[i - 1];
                if (delta < 0)
                {
                    neg += delta;
                    if (neg + fee <= 0)
                    {
                        if (maxProfit > fee)
                        {
                            totalProfit += (maxProfit - fee);
                        }
                        maxProfit = 0;
                        profit = 0;
                        neg = 0;
                        continue;
                    }
                }
                else
                {
                    neg = Math.Min(0, delta + neg);
                }

                profit = Math.Max(0, profit + delta);
                maxProfit = Math.Max(profit, maxProfit);
            }
            if (maxProfit > fee)
            {
                totalProfit += (maxProfit - fee);
            }
            return totalProfit;
        }
    }
}
