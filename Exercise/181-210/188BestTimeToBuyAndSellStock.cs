using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _188BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int k, int[] prices)
        {
            if (prices == null || !prices.Any() || k == 0)
            {
                return 0;
            }
            if (k >= prices.Length / 2)
            {
                return unlimitedTransaction(prices);
            }
            var states = new int[2*k];
            for (var i = 0; i < 2 * k; i++)
            {
                states[i] = Int32.MinValue;
            }
            states[0] = -prices[0];
            for (var i = 1; i < prices.Length; i++)
            {
                states[0] = Math.Max(states[0], -prices[i]);
                for (var j = 1; j < 2 * k - 1; ++j)
                {
                    states[j] = Math.Max(states[j], states[j-1] + prices[i]);
                    ++j;
                    states[j] = Math.Max(states[j], states[j-1] - prices[i]);
                }
                states[2 * k - 1] = Math.Max(states[2*k - 1], states[2*k-2] + prices[i]);
            }
            return Math.Max(0, states[2*k - 1]);
        }

        private int unlimitedTransaction(int[] prices)
        {
            var ret = 0;
            var lastBuy = prices[0];
            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] > lastBuy)
                {
                    ret += prices[i] - lastBuy;
                }
                lastBuy = prices[i];
            }
            return ret;
        }
    }
}
