using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _31NextPermutation
    {
        public void NextPermutation(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return;
            }

            var pre = nums[nums.Length - 1];
            var i = nums.Length - 2;
            var found = false;
            for (; i >= 0; i--)
            {
                if (nums[i] < pre) {
                    found = true;
                    break;
                }
                pre = nums[i];
            }
            if (found)
            {
                
                for (var j = nums.Length - 1; j > i; j--)
                {
                    if (nums[j] > nums[i])
                    {
                        var temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                        break;
                    }
                }
                var end = i - 1;
                for (var j = nums.Length - 1; j > end; j--)
                {
                    var temp = nums[j];
                    nums[j] = nums[end];
                    nums[end] = temp;
                    end++;
                }
            }
            else
            {
                for (var j = 0; j < (nums.Length + 1)/2; j++)
                {
                    var temp = nums[j];
                    nums[j] = nums[nums.Length - 1 - j];
                    nums[nums.Length - 1 - j] = temp;
                }
            }
        }
    }
}
