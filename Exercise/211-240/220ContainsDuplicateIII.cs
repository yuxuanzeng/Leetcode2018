using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _220ContainsDuplicateIII
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (nums == null || nums.Length <= 0)
            {
                return false;
            }

            if (k <= 0)
            {
                return false;
            }
            var lo = 0;
            var hi = 1;
            while (hi < nums.Length)
            {
                if (lo == hi)
                {
                    hi++;
                    continue;
                }
                Int64 res = (Int64)nums[hi] - (Int64)nums[lo];
                if (Math.Abs(res) <= t)
                {
                    return true;
                }
                if (hi - lo < k)
                {
                    hi ++;
                }
                else
                {
                    lo++;
                }
            }
            return false;
        }
    }
}
