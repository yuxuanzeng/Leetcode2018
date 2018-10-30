using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _53MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var max = Int32.MinValue;
            var sum = 0;
            foreach (var num in nums)
            {
                if (sum < 0)
                {
                    sum = num;
                }
                else
                {
                    sum += num;
                }
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
    }
}
