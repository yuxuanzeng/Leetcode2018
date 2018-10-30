using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _152MaximumProductSubarray
    {
        public int MaxProduct(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            var max = nums[0];
            var min = nums[0];
            var ret = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                var temp = max;
                max = Math.Max(nums[i], Math.Max(max * nums[i], min * nums[i]));
                min = Math.Min(nums[i], Math.Min(temp * nums[i], min * nums[i]));
                if (max > ret)
                {
                    ret = max;
                }
            }
            return ret;
        }
    }
}
