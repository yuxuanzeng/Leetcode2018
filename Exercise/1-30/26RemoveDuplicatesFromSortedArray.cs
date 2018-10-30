using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _26RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            var nextIndex = 1;
            var prev = nums[0];
            var len = 1;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != prev)
                {
                    nums[nextIndex] = nums[i];
                    prev = nums[i];
                    nextIndex++;
                    len++;
                }
            }

            return len;
        }
    }
}
