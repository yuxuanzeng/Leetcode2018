using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _162FindPeakElement
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            var lo = 0;
            var hi = nums.Length - 1;
            while (lo < hi - 1)
            {
                var mid = lo + (hi - lo) / 2;
                var prev = mid - 1 > lo ? mid - 1 : lo;
                var next = mid + 1 < hi ? mid + 1 : hi;
                if (nums[mid] > nums[prev])
                {
                    if (nums[mid] > nums[next])
                    {
                        return mid;
                    }
                    else
                    {
                        lo = mid;
                    }
                }
                else
                {
                    hi = mid;
                }
            }
            return nums[lo] > nums[hi] ? lo : hi;
        }
    }
}
