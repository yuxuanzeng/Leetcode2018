using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _35SearchInsertPositioin
    {
        public int SearchInsert(int[] nums, int target)
        {
            return FindInsertingIndex(nums, target, 0, nums.Length - 1);
        }

        public int FindInsertingIndex(int[] nums, int target, int lo, int hi)
        {
            var mid = lo + (hi - lo) / 2;
            if (lo == hi || mid == lo)
            {
                if (nums[lo] >= target)
                {
                    return lo;
                }
                if (nums[hi] < target)
                {
                    return hi + 1;
                }
                return lo + 1;
            }

            if (nums[mid] > target)
            {
                if (nums[mid - 1] < target)
                {
                    return mid;
                }
                return FindInsertingIndex(nums, target, lo, mid - 1);
            }
            else if (nums[mid] == target)
            {
                if (nums[mid - 1] < target)
                {
                    return mid;
                }
                return FindInsertingIndex(nums, target, lo, mid - 1);

            }
            else
            {
                if (nums[mid + 1] >= target)
                {
                    return mid + 1;
                }
                return FindInsertingIndex(nums, target, mid + 1, hi);
            }
        }

    }
}
