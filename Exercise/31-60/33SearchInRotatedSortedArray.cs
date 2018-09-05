using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _33SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }
            if (nums.Length == 1)
            {
                if (nums[0] != target)
                {
                    return -1;
                }
                return 0;
            }

            return Search(nums, target, 0, nums.Length - 1);
        }

        public int Search(int[] nums, int target, int start, int end)
        {
            var mid = start + (end - start) / 2;
            if (target == nums[mid])
            {
                return mid;
            }
            if (start >= end)
            {
                return -1;
            }
            if (target > nums[mid])
            {
                if (target < nums[start])
                {
                    return Search(nums, target, mid + 1, end);
                }
                else
                {
                    if (nums[mid] >= nums[start])
                    {
                        return Search(nums, target, mid + 1, end);
                    }
                    return Search(nums, target, start, mid - 1);
                }
            }
            else
            {
                if (target > nums[end])
                {
                    return Search(nums, target, start, mid - 1);
                }
                else
                {
                    if (nums[mid] > nums[end])
                    {
                        return Search(nums, target, mid + 1, end);
                    }
                    return Search(nums, target, start, mid - 1);
                }
            }
        }
    }
}
