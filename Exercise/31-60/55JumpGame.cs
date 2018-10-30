using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _55JumpGame
    {
        //public bool CanJump(int[] nums)
        //{
        //    if (nums == null)
        //    {
        //        return false;
        //    }

        //    if (nums.Length > 1 && nums[0] == 0)
        //    {
        //        return false;
        //    }
        //    var lo = 0;
        //    while (lo < nums.Length - 1)
        //    {
        //        if (nums[lo] == 0)
        //        {
        //            var j = lo - 1;
        //            while (j >= 0)
        //            {
        //                if (nums[j] > lo - j)
        //                {
        //                    break;
        //                }
        //                j--;
        //            }
        //            if (j < 0)
        //            {
        //                return false;
        //            }
        //        }
        //        lo++;
        //    }
        //    return true;
        //}

        public bool CanJump(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return true;
            }
            var step = nums[0];
            var i = 1;
            while (i < nums.Length)
            {
                step--;
                if (step < 0)
                {
                    return false;
                }
                if (nums[i] > step)
                {
                    step = nums[i];
                }
                i++;
            }
            return true;
        }
    }
}
