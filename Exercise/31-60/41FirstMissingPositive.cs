using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _41FirstMissingPositive
    {
        public int FirstMissingPositive(int[] nums)
        {
            if (nums == null || nums.Length == 0) {
                return 1;
            }
            for (var i = 0; i < nums.Length; i++) {
                if (nums[i] > 0 && nums[i] < nums.Length && nums[nums[i] - 1] != nums[i]) {
                    var temp = nums[nums[i] - 1];
                    nums[nums[i] - 1] = nums[i];
                    nums[i] = temp;
                    i--;
                }
            }

            var j = 0;
            for (; j < nums.Length; j++) {
                if (nums[j] != j + 1) {
                    break;
                }
            }
            return j + 1;
        }
    }
}
