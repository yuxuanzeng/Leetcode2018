using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _330PatchingArray
    {
        public int MinPatches(int[] nums, int n)
        {
            int patches = 0;
            long curMax = 0;
            if (nums == null || nums.Length == 0)
            {
                //patches++;
                while (Math.Pow(2, patches) - 1 < n) {
                    patches++;
                }
                return patches;
            }

            if (nums[0] != 1)
            {
                patches = MinPatches(null, Math.Min(nums[0], n));
            }
            curMax = (long)Math.Pow(2, patches) - 1 + nums[0];
            var index = 1;
            var nextMax = index < nums.Length ? Math.Min(nums[index] - 1, n) : n;
            //index = 1;
            while (curMax < n)
            {
                while (curMax < nextMax)
                {
                    curMax += (curMax + 1);
                    patches++;
                }

                if (index < nums.Length)
                {
                    curMax += nums[index];
                }
                index++;
                nextMax = index < nums.Length ? Math.Min(nums[index] - 1, n) : n;
            }
            return patches;
        }
    }
}
