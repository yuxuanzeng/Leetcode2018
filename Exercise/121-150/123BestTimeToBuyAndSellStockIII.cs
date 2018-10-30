using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _123BestTimeToBuyAndSellStockIII
    {
        public int MaxProfit(int[] prices)
        {
            var profits = new List<int>();
            var profit = 0;
            var maxProfit = 0;
            var maxProfitDay = 0;
            var interNeg = new List<int>();
            var minNeg = 0;
            var minNegDay = 0;

            for (var i = 1; i <= prices.Length; i++)
            {
                if (i == prices.Length)
                {
                    if (maxProfit != 0)
                    {
                        if (minNeg < 0 && minNegDay < maxProfitDay)
                        {
                            interNeg.Add(minNeg);
                            minNeg = 0;
                        }
                        profits.Add(maxProfit);
                    }
                    maxProfit = 0;
                    profit = 0;
                    minNeg = 0;
                    i = maxProfitDay + 1;
                    continue;
                }
                var delta = prices[i] - prices[i - 1];
                if (profit + delta >= 0)
                {
                    if (delta <= 0)
                    {
                        minNeg += delta;
                        minNegDay = i;
                    }
                    profit += delta;
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                        maxProfitDay = i;
                    }
                }
                else
                {
                    if (minNeg < 0)
                    {
                        interNeg.Add(minNeg);
                        minNeg = 0;
                    }
                    profits.Add(maxProfit);
                    maxProfit = 0;
                    profit = 0;
                    minNeg = 0;
                    i = maxProfitDay + 1;
                }
            }
            if (maxProfit != 0)
            {
                if (minNeg < 0 && minNegDay < maxProfitDay)
                {
                    interNeg.Add(minNeg);
                    minNeg = 0;
                }
                profits.Add(maxProfit);
            }

            profits = profits.Where(p => p!=0).ToList();
            if (profits.Count() <= 0)
            {
                return 0;
            }
            else if (profits.Count() <= 1)
            {
                return profits.FirstOrDefault() - interNeg.OrderBy(i => i).FirstOrDefault();
            }
            else
            {
                var temp = profits.OrderByDescending(p => p).ToArray();
                return temp[0] + temp[1];
            }
        }
    }
}
