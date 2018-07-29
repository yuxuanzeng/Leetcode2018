using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _746MinCostClimbingStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if (cost.Length == 2)
            {
                return Math.Min(cost[0], cost[1]);
            }

            //var D = new int[cost.Length, cost.Length];
            //for (var i = 0; i < cost.Length; i++)
            //{
            //    for (var j = 0; j < cost.Length; j++)
            //    {
            //        D[i,j] = -1;
            //    }
            //}
            var D = new int[cost.Length];
            for (var i = 0; i < cost.Length; i++) {
                D[i] = -1;
            }
            var min = cost[0] + MinCostClimbingStairs(cost, 1, D);
            var min2 = cost[1] + MinCostClimbingStairs(cost, 2, D);

            return Math.Min(min, min2);
        }

        private int MinCostClimbingStairs(int[] cost, int index, int[] D)
        {
            if (D[index] != -1) {
                return D[index];
            }
            if (cost.Length - index == 1) {
                D[index] = 0;
                return D[index];
            }
            if (cost.Length - index == 2) {
                D[index] = Math.Min(cost[index], cost[index + 1]);
                return D[index];
            }

            var min = cost[index] + MinCostClimbingStairs(cost, index + 1, D);
            var min2 = cost[index + 1] + MinCostClimbingStairs(cost, index + 2, D);

            D[index] = Math.Min(min, min2);
            return D[index];
        }
    }
}
