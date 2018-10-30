using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _377CombinationSumIV
    {

        //public int CombinationSum4(int[] nums, int target)
        //{
        //    var dp = new int[target + 1];
        //    for (var i = 0; i <= target; ++i)
        //    {
        //        dp[i] = -1;
        //    }
        //    dp[0] = 1;
        //    var res = helper(dp, nums, target);
        //    return res;
        //}

        //public int helper(int[] dp, int[] nums, int target)
        //{
        //    if (dp[target] != -1)
        //    {
        //        return dp[target];
        //    }
        //    var res = 0;
        //    foreach (var num in nums)
        //    {
        //        if (target >= num)
        //        {
        //            res += helper(dp, nums, target - num);
        //        }
        //    }
        //    dp[target] = res;
        //    return res;
        //}

        public int CombinationSum4(int[] nums, int target)
        {
            var comb = new int[target + 1];
            comb[0] = 1;
            for (int i = 1; i < comb.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i - nums[j] >= 0)
                    {
                        comb[i] += comb[i - nums[j]];
                    }
                }
            }
            return comb[target];
        }
    }
}
