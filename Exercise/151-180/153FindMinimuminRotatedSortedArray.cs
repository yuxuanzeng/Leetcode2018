using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _153FindMinimuminRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            if (nums.Length == 2)
            {
                return nums[0] > nums[1] ? nums[1] : nums[0];
            }
            var lo = 0;
            var hi = nums.Length - 1;
            var mid = lo + (hi - lo) / 2;
            if (nums[hi] > nums[lo])
            {
                return nums[lo];
            }
            while (lo < hi - 1)
            {
                mid = lo + (hi - lo) / 2;
                if (nums[mid] > nums[lo])
                {
                    lo = mid;
                }
                else if (nums[mid] < nums[hi])
                {
                    hi = mid;
                }
                else
                {
                    hi--;
                }
            }
            return nums[lo] > nums[hi] ? nums[hi] : nums[lo];
        }
    }
}
