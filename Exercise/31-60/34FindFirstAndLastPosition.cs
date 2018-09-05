using System.Collections.Generic;

namespace Exercise
{
    public class _34FindFirstAndLastPosition
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return new List<int> { -1, -1 }.ToArray();
            }
            var small = target * 10 - 5;
            var large = target * 10 + 5;

            // Find inserting index of small in the nums
            var sIn = FindInsertingIndex(nums, small, 0 , nums.Length - 1);
            // Find inserting index of large in the nums
            var lIn = FindInsertingIndex(nums, large, 0, nums.Length - 1);
            if (sIn == lIn)
            {
                return new List<int> { -1, -1 }.ToArray();
            }
            return new List<int> { sIn, lIn - 1 }.ToArray();
        }

        public int FindInsertingIndex(int[] nums, int target, int lo, int hi)
        {
            var mid = lo + (hi - lo) / 2;
            if (lo == hi || mid == lo)
            {
                if (nums[lo] * 10 > target)
                {
                    return lo;
                }
                if (nums[hi] * 10 < target)
                {
                    return hi + 1;
                }
                return lo + 1;
            }

            if (nums[mid] * 10 > target)
            {
                if (nums[mid - 1] * 10 < target)
                {
                    return mid;
                }
                return FindInsertingIndex(nums, target, lo, mid - 1);
            }
            else
            {
                if (nums[mid + 1] * 10 > target)
                {
                    return mid + 1;
                }
                return FindInsertingIndex(nums, target, mid + 1, hi);
            }
        }
    }
}
