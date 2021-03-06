﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _121BestTimeToBuyAndSellStock_2
    {
        public int MaxProfit(int[] prices)
        {
            var ret = 0;
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }
            var lowestToBuy = prices[0];
            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] - lowestToBuy > ret)
                {
                    ret = prices[i] - lowestToBuy;
                }
                if (prices[i] < lowestToBuy)
                {
                    lowestToBuy = prices[i];
                }
            }
            return ret;
        }
    }
}
