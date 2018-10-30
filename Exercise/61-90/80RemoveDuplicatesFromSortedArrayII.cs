using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _80RemoveDuplicatesFromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return 0;
            }

            var prev = nums[0];
            var nextIndex = 1;
            var len = 1;
            var count = 1;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != prev || count < 2)
                {
                    nums[nextIndex] = nums[i];
                    nextIndex++;
                    len++;
                    if (nums[i] == prev)
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    prev = nums[i];
                }
            }

            return len;
        }
    }
}
