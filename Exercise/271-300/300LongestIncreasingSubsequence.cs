using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _300LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            var sub = new int[nums.Length];
            sub[0] = nums[0];
            var size = 1;
            for (var i = 1; i < nums.Length; i++)
            {
                var pos = Search(sub, size, nums[i]);
                sub[pos] = nums[i];
                if (pos + 1 > size)
                {
                    size = pos + 1;
                }
            }
            return size;
        }

        private int Search(int[] nums, int len, int target)
        {
            var lo = 0;
            var hi = len - 1;
            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    hi = mid;
                }
                else
                {
                    lo = mid + 1;
                }
            }
            if (nums[lo] >= target)
            {
                return lo;
            }
            return lo + 1;
        }
    }
}
