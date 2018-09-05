using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _287FindTheDuplicateNumber
    {
        public int FindDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            var lo = 1;
            var hi = nums.Length;
            var counts = new int[nums.Length];
            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                var ave = GetCount(nums, mid, counts);
                if (ave <= mid )
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid;
                }
            }
            return lo;
        }

        private int GetCount(int[] nums, int target, int[] counts)
        {
            if (counts[target - 1] != 0)
            {
                return counts[target - 1];
            }
            var count = 0;
            foreach (var num in nums)
            {
                if (num <= target)
                {
                    count++;
                }
            }
            counts[target - 1] = count;
            return count;
        }
    }
}
