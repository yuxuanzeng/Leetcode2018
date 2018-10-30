using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _123BestTimeToBuyAndSellStock_2
    {
        public int MaxProfit(int[] prices)
        {
            var ret = 0;
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }
            var prof1 = new int[prices.Length];
            var lowest = new int[prices.Length];
            prof1[0] = 0;
            lowest[0] = prices[0];
            for (var i = 1; i < prices.Length; i++)
            {
                prof1[i] = Math.Max(prof1[i-1], prices[i] - lowest[i-1]);
                lowest[i] = Math.Min(lowest[i-1], prices[i]);
            }

            var len = prices.Length;
            var prof2 = new int[len];
            var highest = new int[len];
            prof2[len - 1] = 0;
            highest[len - 1] = prices[len - 1];
            for (var j = len - 2; j >= 0; j--)
            {
                prof2[j] = Math.Max(prof2[j+1], highest[j+1] - prices[j]);
                highest[j] = Math.Max(highest[j+1], prices[j]);
            }

            for (var k = 0; k < len; k++)
            {
                if (prof1[k] + prof2[k] > ret)
                {
                    ret = prof1[k] + prof2[k];
                }
            }
            return ret;
        }
    }
}
